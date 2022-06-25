using System.Collections.Generic;
using Newtonsoft.Json;

namespace Exercise5.Models
{
	public class CheckTotals
	{
		[JsonProperty("checks")]
		public IList<Check> Checks
		{
			get;
			set;
		}
	}
}
