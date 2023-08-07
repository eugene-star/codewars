using System.Text;

namespace AddingBigNumbers
{
	public class Kata
	{
		public static string Add(string a, string b)
		{
			if (a.Length > b.Length)
				b = b.PadLeft(a.Length, '0');
			else
				a = a.PadLeft(b.Length, '0');

			int append = 0;
			var res = new StringBuilder(a.Length + 1);
			for (int i = 1; i <= a.Length; i++)
			{
				int digitA = a[a.Length - i] - '0',
					digitB = b[b.Length - i] - '0',
					digitRes = digitA + digitB + append;

				if (digitRes >= 10)
				{
					digitRes -= 10;
					append = 1;
				}
				else
					append = 0;

				res.Append((char)('0' + digitRes));
			}

			if (append == 1)
				res.Append((char)('0' + append));

			return new string(res.ToString().Reverse().ToArray());
		}
	}
}