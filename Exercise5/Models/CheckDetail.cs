using Newtonsoft.Json;

namespace Exercise5.Models
{
	public class CheckDetail
	{
		[JsonProperty("productId")]
		public int ProductId
		{
			get;
			set;
		}
		[JsonProperty("qty")]
		public decimal Qty
		{
			get;
			set;
		}
		[JsonProperty("checkDetailDiscountId")]
		public int? CheckDetailDiscountId
		{
			get;
			set;
		}
	}
}
