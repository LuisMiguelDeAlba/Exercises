using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Models;
using Newtonsoft.Json;
using NUnit.Framework;

namespace TestExercises
{
	public class Exercise5
	{
		private string ConnectionString => ConfigurationManager.AppSettings["ConnectionString"];
		private string UserName => ConfigurationManager.AppSettings["UserName"];
		private string BaseUrl => ConfigurationManager.AppSettings["BaseUrl"];
		private HttpClient client;

		[SetUp]
		public void Setup()
		{
			var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{UserName}:{GetPassword()}"));
			client = new HttpClient
			{
				BaseAddress = new Uri(BaseUrl)
			};
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			client.DefaultRequestHeaders.Add("Authorization", $"Basic {base64EncodedAuthenticationString}");
		}

		[Test]
		public async Task Test_GetUsers()
		{
			IList<User> users = null;
			var response = await client.GetAsync("users");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				users = JsonConvert.DeserializeObject<IList<User>>(content);
			}
			Assert.NotNull(users);
			Assert.Greater(users.Count, 0);
		}

		[Test]
		public async Task Test_GetUser()
		{
			User user = null;
			var response = await client.GetAsync("users/1");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				user = JsonConvert.DeserializeObject<User>(content);
			}
			Assert.NotNull(user);
		}

		[Test]
		public async Task Test_CreateCheck()
		{
			Check check = null;
			var bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(GetNewCheckTotals()));
			var response = await client.PostAsync("checktotals", new ByteArrayContent(bytes));
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				check = JsonConvert.DeserializeObject<Check>(content);
			}
			Assert.NotNull(check);
			Assert.Greater(check.CheckId, 0);
		}

		[Test]
		public async Task Test_CustomersCRUD()
		{
			int customerId = 0;
			CustomerResponse customerResponse = null;
			// CREATE
			var bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(GetNewCustomer()));
			var response = await client.PostAsync("customers", new ByteArrayContent(bytes));
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				customerId = JsonConvert.DeserializeObject<int>(content);
			}
			Assert.Greater(customerId, 0);
			// READ
			response = await client.GetAsync($"customers/{customerId}");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				customerResponse = JsonConvert.DeserializeObject<CustomerResponse>(content);
			}
			Assert.NotNull(customerResponse);
			Assert.Greater(customerResponse.Customers.Count, 0);
			// UPDATE
			var customer = GetNewCustomer();
			customer.Email = "test123@gmail.com";
			bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(customer));
			response = await client.PutAsync($"customers/{customerId}", new ByteArrayContent(bytes));
			Assert.IsTrue(response.IsSuccessStatusCode);
			// VALIDATE PUT
			response = await client.GetAsync($"customers/{customerId}");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				customerResponse = JsonConvert.DeserializeObject<CustomerResponse>(content);
			}
			Assert.AreEqual(customer.Email, customerResponse.Customers[0].Email);
			// DELETE
			response = await client.DeleteAsync($"customers/{customerId}");
			Assert.IsTrue(response.IsSuccessStatusCode);
			// VALIDATE DELETE
			response = await client.GetAsync($"customers/{customerId}");
			Assert.IsFalse(response.IsSuccessStatusCode);
			Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);
		}


		private string GetPassword()
		{
			var pwd = string.Empty;
			var sql = "SELECT TOP(1) Password FROM Users WHERE FName = @UserName AND Enabled = 1";
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				using SqlCommand command = new SqlCommand(sql, connection);
				command.Parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.NVarChar, 50)
				{
					Value = UserName
				});
				using SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					pwd = reader.GetString(0);
				}
			}
			return pwd;
		}

		private CheckTotals GetNewCheckTotals()
		{
			return new CheckTotals
			{
				Checks = new List<Check>() {
					new Check
					{
						CustomerId = 1000001,
						CheckDiscountId = 1,
						Details = new List<CheckDetail>()
						{
							new CheckDetail
							{
								ProductId = 3,
								Qty = 1
							},
							new CheckDetail
							{
								ProductId = 5,
								Qty = 2,
								CheckDetailDiscountId = 5
							}
						}
					}
				}
			};
		}

		private Customer GetNewCustomer()
		{
			return new Customer
			{
				AccountCreated = new DateTime(2014, 4, 16),
				Address = "123 Billing Street",
				Address2 = "Billpartment 1",
				Birthdate = new DateTime(2001, 5, 10),
				CardId = 123456,
				City = "Billstown",
				Company = "",
				Country = "US",
				CreditLimit = 0,
				CreditOnHold = false,
				Custom1 = "",
				Custom2 = "",
				Custom3 = "",
				Custom4 = "1",
				Deleted = false,
				DoNotEmail = false,
				Email = "someone@mail.com",
				Fax = "",
				FirstName = "Real",
				Gender = 1,
				GeneralNotes = "",
				HowDidYouHearAboutUs = 0,
				IgnoreDOB = false,
				IsEmployee = false,
				IsGiftCard = false,
				LastName = "Fakerson",
				LastVisited = new DateTime(2014, 4, 16),
				LicenseNumber = "",
				MemberShipStatus = 0,
				MembershipText = "",
				MemberShipTextLong = "",
				MobilePhone = "",
				OriginalId = 0,
				PhoneNumber = "123-456-7890",
				PhoneNumber2 = "",
				PriceLevel = 1,
				Privacy1 = false,
				ProSkill = 1200,
				RacerName = "the_real_faker",
				State = "CA",
				Status1 = 1,
				Status2 = 0,
				Status3 = 0,
				Status4 = 0,
				TotalRaces = 3,
				TotalVisits = 1,
				Waiver = 1,
				Waiver2 = 7,
				WebUserName = "",
				Zip = "12345"
			};
		}
	}
}