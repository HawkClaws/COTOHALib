using System;
using System.Collections.Generic;
using System.Text;

namespace COTOHALib.Model
{
	public class KeywordRequest
	{
		/// <summary>
		/// 解析対象の文
		/// </summary>
		public string[] document { get; set; }

		/// <summary>
		/// default - 通常文
		/// kuzure - SNSなどの崩れた文
		/// </summary>
		public string type { get; set; }

		/// <summary>
		/// 文区切りを実施するか否かを指定（省略時:false）
		/// true - documentがstringの場合に文区切りを実施する
		/// false - 文区切りを実施しない
		/// ※documentがarray(string)の場合は本項の指定は無効
		/// </summary>
		public bool do_segment { get; set; }

		/// <summary>
		/// 抽出するキーワードの上限個数（省略時:5）
		/// </summary>
		public int max_keyword_num { get; set; }

		/// <summary>
		/// 使用する専門用語辞書を指定する。以下のタイプから複数指定可能。(for Enterpriseユーザのみ)
		/// </summary>
		public string dic_type { get; set; }

	}
}
