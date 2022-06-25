using System.Collections.Generic;
using Newtonsoft.Json;

namespace Exercise5.Models
{
	public class Check
	{
		[JsonProperty("checkId")]
		public int CheckId
		{
			get;
			set;
		}
		[JsonProperty("customerId")]
		public int CustomerId
		{
			get;
			set;
		}
		[JsonProperty("checkDiscountId")]
		public int CheckDiscountId
		{
			get;
			set;
		}
		[JsonProperty("details")]
		public IList<CheckDetail> Details
		{
			get;
			set;
		}
	}
}
