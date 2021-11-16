using System;
using System.Collections.Generic;
using System.Text;

namespace COTOHALib.Model
{
	public class SentimentResult
	{
		/// <summary>
		/// 感情分析結果。Positive/Negative/Neutralのいずれかを出力する
		/// </summary>
		public string sentiment { get; set; }

		/// <summary>
		/// センチメントスコア
		/// </summary>
		public float score { get; set; }

		public EmotionalPhrase[] emotional_phrase { get; set; }

	}

	public class EmotionalPhrase
	{

		/// <summary>
		/// 表記
		/// </summary>
		public string form { get; set; }

		/// <summary>
		/// 表記に対応する感情語
		/// </summary>
		public string emotion { get; set; }

	}
}
