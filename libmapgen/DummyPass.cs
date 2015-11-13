using System.Collections.Generic;
namespace libmapgen
{
	public class DummyPass : IMapPass
	{
		public DummyPass () { }

		public Dictionary<string, System.Type> getSettings() {
			return null;
		}

		public void setSetting(string setting, object value) {
		}

		public void call(MapArea map) {
			// do nothing!
		}
	}
}

