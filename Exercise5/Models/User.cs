using System;

namespace Exercise5.Models
{
	public class User
	{
		public int UserId
		{
			get;
			set;
		}
		public string FirstName
		{
			get;
			set;
		}
		public string LastName
		{
			get;
			set;
		}
		public string UserName
		{
			get;
			set;
		}
		public int CardId
		{
			get;
			set;
		}
		public bool Enabled
		{
			get;
			set;
		}
		public string Email
		{
			get;
			set;
		}
		public string Phone
		{
			get;
			set;
		}
		public bool Deleted
		{
			get;
			set;
		}
		public DateTime? EmpStartDate
		{
			get;
			set;
		}
		public bool IsSystemUser
		{
			get;
			set;
		}
	}
}
