using COTOHALib.Model;
using COTOHALib.OAuthModel;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;


namespace COTOHALib
{
	public class COTOHA
	{
		public COTOHA(AccessTokens accessTokens)
		{
			this.AccessTokens = accessTokens;
		}

		private const string API_BASE_URL = "https://api.ce-cotoha.com/api/dev/";
		private AccessTokens AccessTokens;
		private static HttpClient _httpClient = new HttpClient();
		private HttpClientHelper _httpClientHelper = new HttpClientHelper();

		/// <summary>
		/// ユーザ属性推定(β)
		/// https://api.ce-cotoha.com/contents/reference/apireference.html#user
		/// </summary>
		/// <param name="userAttributeModel"></param>
		/// <returns></returns>
		public UserAttributeResponse UserAttribute(UserAttributeRequest userAttributeModel)
		{
			string jsonString = JsonConvert.SerializeObject(userAttributeModel);
			var request = _httpClientHelper.CreateRequest(HttpMethod.Post, API_BASE_URL + "nlp/beta/user_attribute", AccessTokens.access_token, jsonString);
			var res = _httpClient.SendAsync(request).Result;
			return JsonConvert.DeserializeObject<UserAttributeResponse>(res.Content.ReadAsStringAsync().Result);
		}

		/// <summary>
		/// 感情分析
		/// https://api.ce-cotoha.com/contents/reference/apireference.html#sentiment
		/// </summary>
		/// <param name="sentimentRequest"></param>
		/// <returns></returns>
		public SentimentResponse Sentiment(SentimentRequest sentimentRequest)
		{
			string jsonString = JsonConvert.SerializeObject(sentimentRequest);
			var request = _httpClientHelper.CreateRequest(HttpMethod.Post, API_BASE_URL + "nlp/v1/sentiment", AccessTokens.access_token, jsonString);
			var res = _httpClient.SendAsync(request).Result;
			return JsonConvert.DeserializeObject<SentimentResponse>(res.Content.ReadAsStringAsync().Result);
		}

		/// <summary>
		/// キーワード抽出
		/// https://api.ce-cotoha.com/contents/reference/apireference.html#keyword
		/// </summary>
		/// <param name="keywordRequest"></param>
		/// <returns></returns>
		public KeywordResponse Keyword(KeywordRequest keywordRequest)
		{
			string jsonString = JsonConvert.SerializeObject(keywordRequest);
			var request = _httpClientHelper.CreateRequest(HttpMethod.Post, API_BASE_URL + "nlp/v1/keyword", AccessTokens.access_token, jsonString);
			var res = _httpClient.SendAsync(request).Result;
			return JsonConvert.DeserializeObject<KeywordResponse>(res.Content.ReadAsStringAsync().Result);
		}
	}
}
