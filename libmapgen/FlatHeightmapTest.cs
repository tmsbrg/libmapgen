using NUnit.Framework;
using System;

namespace libmapgen
{
	[TestFixture()]
	public class FlatHeightmapTest
	{
		[Test()]
		public void MapGen()
		{
			FlatHeightmap gen = new FlatHeightmap (3, 4);
			MapArea map = gen.generate ();

			Assert.AreEqual (3, map.width);
			Assert.AreEqual (4, map.height);

			Assert.AreEqual(0, map.getHeightAt(0, 0));
			Assert.AreEqual(0, map.getHeightAt(2, 3));
		}
	}
}

