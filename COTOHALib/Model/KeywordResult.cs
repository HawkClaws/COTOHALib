using System;
using System.Collections.Generic;
using System.Text;

namespace COTOHALib.Model
{
	public class KeywordResult
	{
		/// <summary>
		/// キーワード
		/// </summary>
		public string form { get; set; }

		/// <summary>
		/// キーワードのスコア
		/// </summary>
		public float score { get; set; }
	}
}
