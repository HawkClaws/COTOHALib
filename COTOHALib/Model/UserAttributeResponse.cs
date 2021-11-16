using System;
using System.Collections.Generic;
using System.Text;

namespace COTOHALib.Model
{
	public class UserAttributeResponse
	{
		public UserAttributeResult result { get; set; }
		public int status { get; set; }
		public string message { get; set; }
	}
}
