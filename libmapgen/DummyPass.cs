using System;

namespace libmapgen
{
    [Serializable()]
	public class DummyPass : IMapPass
	{
		public DummyPass () { }

		public void call(MapArea map) {
			// do nothing!
		}
	}
}
