using System;
using System.Collections.Generic;
using System.Text;

namespace COTOHALib.OAuthModel
{
	public class Credentials
	{
		public string grantType { get; set; } = "client_credentials";
		public string clientId { get; set; }
		public string clientSecret { get; set; }
	}
}
