using NUnit.Framework;
using System;

namespace libmapgen
{
	[TestFixture()]
	public class MapAreaTest
	{
		[Test()]
		public void MapArea ()
		{
			MapArea map = new MapArea (10, 20);

			Assert.AreEqual (10, map.width);
			Assert.AreEqual (20, map.height);

			Assert.AreEqual (0, map.getHeightAt (0, 0));
			Assert.AreEqual (0, map.getHeightAt (9, 19));
			Assert.AreEqual (0, map.getHeightAt (7, 4));
			Assert.AreEqual (0, map.getHeightAt (5, 10));
		}

		[Test()]
		public void EmptyMap ()
		{
			MapArea map = new MapArea (20, 0);

			Assert.AreEqual (0, map.height);
			Assert.AreEqual (0, map.width);
		}

		[Test()]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void MapAreaWidthException()
		{
			MapArea map = new MapArea (3, 3);
			map.getHeightAt (3, 0);
		}

		[Test()]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void MapAreaHeightException()
		{
			MapArea map = new MapArea (3, 3);
			map.getHeightAt (0, 3);
		}
	}
}

