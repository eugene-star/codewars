// https://www.codewars.com/kata/541af676b589989aed0009e7/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCombinations
{
	public static class Kata
	{
		public static int CountCombinations(int money, int[] coins)
		{
			int res = 0;

			if (coins.Length > 0)
				for (int j = 0; j <= money / coins[0]; j++)
				{
					int remainder = money - j * coins[0];

					if (coins.Length == 1)
					{
						if (remainder == 0)
							return 1;
					}
					else
					{
						var coinsReduced = coins.ToList();
						coinsReduced.RemoveAt(0);
						res += CountCombinations(remainder, coinsReduced.ToArray());
					}
				}

			return res;
		}
	}
}