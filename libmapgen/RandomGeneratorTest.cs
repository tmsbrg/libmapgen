using NUnit.Framework;
using System;

namespace libmapgen
{
	[TestFixture()]
	public class RandomGeneratorTest
	{
		[Test()]
		public void GenerationTest ()
		{
			for (var i=0; i<5; i++) {
				Assert.GreaterOrEqual(RandomGenerator.generate (0, 1), 0);
				Assert.Less (RandomGenerator.generate (0, 1), 1);

				Assert.GreaterOrEqual (RandomGenerator.generate (45, 60), 45);
				Assert.Less (RandomGenerator.generate (0, 60), 60);
			}
		}
	}
}

