using System;
using System.Collections.Generic;
using System.Text;

namespace COTOHALib.Model
{
	public class UserAttributeResult
	{
		/// <summary>
		/// 年代
		/// </summary>
		public string age { get; set; }

		/// <summary>
		/// 既婚/未婚
		/// </summary>
		public string civilstatus { get; set; }

		/// <summary>
		/// 給与
		/// </summary>
		public string earnings { get; set; }

		/// <summary>
		/// 性別（女性/男性）
		/// </summary>
		public string gender { get; set; }

		/// <summary>
		/// 習慣
		/// </summary>
		public string[] habit { get; set; }

		/// <summary>
		/// 趣味
		/// </summary>
		public string[] hobby { get; set; }

		/// <summary>
		/// 業種
		/// </summary>
		public string kind_of_bussiness { get; set; }

		/// <summary>
		/// 職種
		/// </summary>
		public string location { get; set; }

		/// <summary>
		/// 出身地
		/// </summary>
		public string[] moving { get; set; }

		/// <summary>
		/// 移動手段
		/// </summary>
		public string occupation { get; set; }

		/// <summary>
		/// 役職
		/// </summary>
		public string position { get; set; }
	}
}
