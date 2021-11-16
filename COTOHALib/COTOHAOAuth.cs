using COTOHALib.OAuthModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace COTOHALib
{
	public class COTOHAOAuth
	{
		private static HttpClient _httpClient = new HttpClient();

		public AccessTokens OAuth(Credentials credentials)
		{
			string jsonString = JsonConvert.SerializeObject(credentials);
			var res = _httpClient.PostAsync("https://api.ce-cotoha.com/v1/oauth/accesstokens", new StringContent(jsonString, Encoding.UTF8, "application/json")).Result;
			return JsonConvert.DeserializeObject<AccessTokens>(res.Content.ReadAsStringAsync().Result);
		}
	}
}
