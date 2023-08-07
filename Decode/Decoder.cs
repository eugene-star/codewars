// https://www.codewars.com/kata/52cf02cd825aef67070008fa/train/csharp

using System;
using System.Text;

public static class Decoder
{
	public static readonly string Vocabluary = "abdhpF,82QsLirJejtNmzZKgnB3SwTyXG ?.6YIcflxVC5WE94UA1OoD70MkvRuPqH";

	public static string Decode(string p_what)
	{
		var sb = new StringBuilder(p_what.Length);
		for (int i = 0; i < p_what.Length; i++)
		{
			int pos = Vocabluary.IndexOf(p_what[i]);
			Console.Write($"{pos} ");
			if (pos == -1)
				sb.Append(p_what[i]);
			else
			{
				pos = pos - i - 1;
				while (pos < 0)
					pos += Vocabluary.Length;
				sb.Append(Vocabluary[pos]);
			}
		}

		return sb.ToString();
	}
}

public static class Encoder
{

	public static string Encode(string p_what)
	{
		var sb = new StringBuilder(p_what.Length);
		for (int i = 0; i < p_what.Length; i++)
		{
			int pos = Decoder.Vocabluary.IndexOf(p_what[i]);
			if (pos == -1)
				sb.Append(p_what[i]);
			else
				sb.Append(Decoder.Vocabluary[(pos + i + 1) % Decoder.Vocabluary.Length]);
		}

		return sb.ToString();
	}
}