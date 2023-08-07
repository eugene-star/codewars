// https://www.codewars.com/kata/526d84b98f428f14a60008da/train/csharp
// https://stackoverflow.com/questions/41177225/hamming-number-using-custom-functions-instead-of-prime

public class HammingNumber
{
	public static long GetNth(int n)
	{
		var numbers = new List<long>(n) { 1 };
		var nextList = new List<long>(3);

		int i2, i3, i5;
		i2 = i3 = i5 = 0;

		for (int i = 1; i < n; i++)
		{
			nextList.Add(numbers[i2] * 2);
			nextList.Add(numbers[i3] * 3);
			nextList.Add(numbers[i5] * 5);

			var next = nextList.Min();
			numbers.Add(next);

			if (nextList[0] == next) ++i2;
			if (nextList[1] == next) ++i3;
			if (nextList[2] == next) ++i5;

			nextList.Clear();
		}

		return numbers.Last();
	}
}