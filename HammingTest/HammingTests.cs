using System;
using NUnit.Framework;

[TestFixture]
public class HammingTests
{

	[Test]
	public void Test1()
	{
		Assert.AreEqual(1, HammingNumber.GetNth(1), "hamming(1) should be 1");
		Assert.AreEqual(2, HammingNumber.GetNth(2), "hamming(2) should be 2");
		Assert.AreEqual(3, HammingNumber.GetNth(3), "hamming(3) should be 3");
		Assert.AreEqual(4, HammingNumber.GetNth(4), "hamming(4) should be 4");
		Assert.AreEqual(5, HammingNumber.GetNth(5), "hamming(5) should be 5");
		Assert.AreEqual(6, HammingNumber.GetNth(6), "hamming(6) should be 6");
		Assert.AreEqual(8, HammingNumber.GetNth(7), "hamming(7) should be 8");
		Assert.AreEqual(9, HammingNumber.GetNth(8), "hamming(8) should be 9");
		Assert.AreEqual(10, HammingNumber.GetNth(9), "hamming(9) should be 10");
		Assert.AreEqual(12, HammingNumber.GetNth(10), "hamming(10) should be 12");
		Assert.AreEqual(15, HammingNumber.GetNth(11), "hamming(11) should be 15");
		Assert.AreEqual(16, HammingNumber.GetNth(12), "hamming(12) should be 16");
		Assert.AreEqual(18, HammingNumber.GetNth(13), "hamming(13) should be 18");
		Assert.AreEqual(20, HammingNumber.GetNth(14), "hamming(14) should be 20");
		Assert.AreEqual(24, HammingNumber.GetNth(15), "hamming(15) should be 24");
		Assert.AreEqual(25, HammingNumber.GetNth(16), "hamming(16) should be 25");
		Assert.AreEqual(27, HammingNumber.GetNth(17), "hamming(17) should be 27");
		Assert.AreEqual(30, HammingNumber.GetNth(18), "hamming(18) should be 30");
		Assert.AreEqual(32, HammingNumber.GetNth(19), "hamming(19) should be 32");
	}
}