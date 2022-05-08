using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRoster.Models.Shared
{
	public class UserProfile
	{
		public string? profileId { get; set; }
		public string? profileType { get; set; }
		public string? vendorId { get; set; }
		public string? applicationId { get; set; }
		public string? description { get; set; }
		public Credential? credentials { get; set; }
	}
}
