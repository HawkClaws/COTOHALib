using System;
using System.Collections.Generic;
using System.Text;

namespace COTOHALib.OAuthModel
{
	public class AccessTokens
	{
		public string access_token { get; set; }
		public string token_type { get; set; }
		public string expires_in { get; set; }
		public string scope { get; set; }
		public string issued_at { get; set; }
	}
}
