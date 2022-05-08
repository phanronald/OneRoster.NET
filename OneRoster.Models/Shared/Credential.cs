using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRoster.Models.Shared
{
	public class Credential
	{
		public string? type { get; set; }
		public string? username { get; set; }
		public string? password { get; set; }
		public string? extensions { get; set; }
	}
}
