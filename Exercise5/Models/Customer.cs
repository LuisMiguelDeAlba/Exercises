using System;
using Newtonsoft.Json;

namespace Exercise5.Models
{
	public class Customer
	{
		[JsonProperty("accountCreated")]
		public DateTime? AccountCreated
		{
			get;
			set;
		}
		[JsonProperty("Address")]
		public string Address
		{
			get;
			set;
		}
		[JsonProperty("Address2")]
		public string Address2
		{
			get;
			set;
		}
		[JsonProperty("birthdate")]
		public DateTime? Birthdate
		{
			get;
			set;
		}
		[JsonProperty("cardId")]
		public int CardId
		{
			get;
			set;
		}
		[JsonProperty("City")]
		public string City
		{
			get;
			set;
		}
		[JsonProperty("company")]
		public string Company
		{
			get;
			set;
		}
		[JsonProperty("Country")]
		public string Country
		{
			get;
			set;
		}
		[JsonProperty("creditLimit")]
		public int CreditLimit
		{
			get;
			set;
		}
		[JsonProperty("creditOnHold")]
		public bool CreditOnHold
		{
			get;
			set;
		}
		[JsonProperty("Custom1")]
		public string Custom1
		{
			get;
			set;
		}
		[JsonProperty("Custom2")]
		public string Custom2
		{
			get;
			set;
		}
		[JsonProperty("Custom3")]
		public string Custom3
		{
			get;
			set;
		}
		[JsonProperty("Custom4")]
		public string Custom4
		{
			get;
			set;
		}
		[JsonProperty("deleted")]
		public bool Deleted
		{
			get;
			set;
		}
		[JsonProperty("donotemail")]
		public bool DoNotEmail
		{
			get;
			set;
		}
		[JsonProperty("email")]
		public string Email
		{
			get;
			set;
		}
		[JsonProperty("fax")]
		public string Fax
		{
			get;
			set;
		}
		[JsonProperty("firstname")]
		public string FirstName
		{
			get;
			set;
		}
		[JsonProperty("gender")]
		public int Gender
		{
			get;
			set;
		}
		[JsonProperty("generalNotes")]
		public string GeneralNotes
		{
			get;
			set;
		}
		[JsonProperty("howdidyouhearaboutus")]
		public int HowDidYouHearAboutUs
		{
			get;
			set;
		}
		[JsonProperty("ignoreDOB")]
		public bool IgnoreDOB
		{
			get;
			set;
		}
		[JsonProperty("isEmployee")]
		public bool IsEmployee
		{
			get;
			set;
		}
		[JsonProperty("isGiftCard")]
		public bool IsGiftCard
		{
			get;
			set;
		}
		[JsonProperty("lastname")]
		public string LastName
		{
			get;
			set;
		}
		[JsonProperty("lastVisited")]
		public DateTime? LastVisited
		{
			get;
			set;
		}
		[JsonProperty("LicenseNumber")]
		public string LicenseNumber
		{
			get;
			set;
		}
		[JsonProperty("membershipStatus")]
		public int MemberShipStatus
		{
			get;
			set;
		}
		[JsonProperty("membershipText")]
		public string MembershipText
		{
			get;
			set;
		}
		[JsonProperty("memberShipTextLong")]
		public string MemberShipTextLong
		{
			get;
			set;
		}
		[JsonProperty("mobilephone")]
		public string MobilePhone
		{
			get;
			set;
		}
		[JsonProperty("originalId")]
		public int OriginalId
		{
			get;
			set;
		}
		[JsonProperty("phoneNumber")]
		public string PhoneNumber
		{
			get;
			set;
		}
		[JsonProperty("phoneNumber2")]
		public string PhoneNumber2
		{
			get;
			set;
		}
		[JsonProperty("priceLevel")]
		public int PriceLevel
		{
			get;
			set;
		}
		[JsonProperty("privacy1")]
		public bool Privacy1
		{
			get;
			set;
		}
		[JsonProperty("proskill")]
		public int ProSkill
		{
			get;
			set;
		}
		[JsonProperty("racername")]
		public string RacerName
		{
			get;
			set;
		}
		[JsonProperty("State")]
		public string State
		{
			get;
			set;
		}
		[JsonProperty("status1")]
		public int Status1
		{
			get;
			set;
		}
		[JsonProperty("status2")]
		public int Status2
		{
			get;
			set;
		}
		[JsonProperty("status3")]
		public int Status3
		{
			get;
			set;
		}
		[JsonProperty("status4")]
		public int Status4
		{
			get;
			set;
		}
		[JsonProperty("totalRaces")]
		public int TotalRaces
		{
			get;
			set;
		}
		[JsonProperty("totalVisits")]
		public int TotalVisits
		{
			get;
			set;
		}
		[JsonProperty("waiver")]
		public int Waiver
		{
			get;
			set;
		}
		[JsonProperty("waiver2")]
		public int Waiver2
		{
			get;
			set;
		}
		[JsonProperty("webUserName")]
		public string WebUserName
		{
			get;
			set;
		}
		[JsonProperty("Zip")]
		public string Zip
		{
			get;
			set;
		}
	}
}