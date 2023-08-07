// https://www.codewars.com/kata/563fbac924106b8bf7000046

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Breadcrumb
{
	public class Kata
	{

		public static string GenerateBC(string url, string separator)
		{
			if (!url.StartsWith("http", StringComparison.CurrentCultureIgnoreCase))
				url = "http://" + url;
			Uri uri = new Uri(url);
			//Match m = Regex.Match(url, "^(https?:\\/\\/)?([\\w\\.]+)\\.([a-z]{2,6}\\.?)(\\/[\\w\\.]*?)*\\/?$");
			return "";
		}
	}
}
