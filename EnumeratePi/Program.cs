using System;
using System.Numerics;

namespace PiCalc
{
	class Program
	{
		readonly BigInteger FOUR = new BigInteger(4);
		readonly BigInteger SEVEN = new BigInteger(7);
		readonly BigInteger TEN = new BigInteger(10);
		readonly BigInteger THREE = new BigInteger(3);
		readonly BigInteger TWO = new BigInteger(2);

		BigInteger k = BigInteger.One;
		BigInteger l = new BigInteger(3);
		BigInteger n = new BigInteger(3);
		BigInteger q = BigInteger.One;
		BigInteger r = BigInteger.Zero;
		BigInteger t = BigInteger.One;

		public void CalcPiDigits()
		{
			BigInteger nn, nr;
			bool first = true;
			while (true)
			{

				if ((FOUR * q + r - t).CompareTo(n * t) == -1)
				{
					Console.Write(n);
					if (first)
					{
						Console.Write(".");
						first = false;
					}
					nr = TEN * (r - (n * t));
					n = TEN * (THREE * q + r) / t - (TEN * n);
					q *= TEN;
					r = nr;
				}
				else
				{
					nr = (TWO * q + r) * l;
					nn = (q * (SEVEN * k) + TWO + r * l) / (t * l);
					q *= k;
					t *= l;
					l += TWO;
					k += BigInteger.One;
					n = nn;
					r = nr;
				}
			}
		}

		static void Main(string[] args)
		{
			Program program = new Program();
			program.CalcPiDigits();
		}
	}
}