using System;

namespace libmapgen
{
	[Serializable()]
	public class FlattenPass : IMapPass
	{
		public float h;
		public bool greater_than;

		public FlattenPass (float h=0.5f, bool greater_than=false) {
			this.h = h;
			this.greater_than = greater_than;
		}

		public void call(MapArea map) {
			int height = map.height;
			int width = map.width;
			for (var y=0; y<height; y++) {
				for (var x=0; x<width; x++) {
					float tile_h = map.getHeightAt(x, y);
					if ((greater_than && tile_h > h) || (!greater_than && tile_h < h)) {
						map.setHeightAt(x, y, h);
					}
				}
			}
		}
	}
}
