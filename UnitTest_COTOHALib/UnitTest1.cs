using COTOHALib;
using COTOHALib.OAuthModel;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Diagnostics;

namespace UnitTest_COTOHALib
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			COTOHAOAuth COTOHALibOAuth = new COTOHAOAuth();
			var token = COTOHALibOAuth.OAuth(new Credentials() { clientId = "Your clientId", clientSecret = "Your clientSecret" });

			COTOHA cOTOHA = new COTOHA(token);

			var res = cOTOHA.UserAttribute(new COTOHALib.Model.UserAttributeRequest()
			{
				document = new string[] { "���͍���c���w�ň��݂ɍs�����牜����ɓ{��ꂽ�B" },
				type = "default"
			});

			Debug.WriteLine(JsonConvert.SerializeObject(res));

			var res2 = cOTOHA.Sentiment(new COTOHALib.Model.SentimentRequest()
			{
				sentence = "�l���̏t��搉̂��Ă��܂�"
			});

			Debug.WriteLine(JsonConvert.SerializeObject(res2));


			var res3 = cOTOHA.Keyword(new COTOHALib.Model.KeywordRequest()
			{
				document = new string[] { "���X�g�����Œ��H��H�ׂ��B" },
				type = "default",

			});
			Debug.WriteLine(JsonConvert.SerializeObject(res3));

		}
	}
}