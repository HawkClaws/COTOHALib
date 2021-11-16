using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace COTOHALib
{
	public class HttpClientHelper
	{
		public HttpRequestMessage CreateRequest(HttpMethod httpMethod, string url, string access_token, string json)
		{
			var request = new HttpRequestMessage(HttpMethod.Post, url);
			request.Headers.Add("ContentType", "application/json;charset=UTF-8");
			request.Headers.Add("Authorization", "Bearer " + access_token);
			request.Content = new StringContent(json, Encoding.UTF8, "application/json");
			return request;
		}
	}
}
