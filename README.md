# COTOHALib
NTTコミュニケーションズのCOTOHA APIの.NETラッパーライブラリです

https://api.ce-cotoha.com/contents/index.html


### 使い方
会員登録を行い、ClientId、ClientSecretを取得してください

CredentialsにclientIdとclientSecretを設定してください

```C#
COTOHAOAuth COTOHALibOAuth = new COTOHAOAuth();
var token = COTOHALibOAuth.OAuth(new Credentials() { clientId = "Your clientId", clientSecret = "Your clientSecret" });

COTOHA cOTOHA = new COTOHA(token);

var res = cOTOHA.UserAttribute(new COTOHALib.Model.UserAttributeRequest()
{
	document = new string[] { "私は昨日田町駅で飲みに行ったら奥さんに怒られた。" },
	type = "default"
});

Debug.WriteLine(JsonConvert.SerializeObject(res));

var res2 = cOTOHA.Sentiment(new COTOHALib.Model.SentimentRequest()
{
	sentence = "人生の春を謳歌しています"
});

Debug.WriteLine(JsonConvert.SerializeObject(res2));


var res3 = cOTOHA.Keyword(new COTOHALib.Model.KeywordRequest()
{
	document = new string[] { "レストランで昼食を食べた。" },
	type = "default",

});
Debug.WriteLine(JsonConvert.SerializeObject(res3));
```
