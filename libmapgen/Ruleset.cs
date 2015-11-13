using System;
using System.Collections.Generic;

namespace libmapgen
{
	[Serializable()]
	public class Ruleset
	{
		public IInitialMapGenerator generator;
		public List<IMapPass> passes;

		public Ruleset (IInitialMapGenerator g=null)
		{
			generator = (g != null) ? g :
				        new FlatHeightmap (10, 10);
			passes = new List<IMapPass> ();
		}

		public MapArea generate()
		{
			// TODO: exception or such if you don't have a generator
			MapArea map = generator.generate ();
			foreach (var pass in passes)
			{
				pass.call (map);
			}
			return map;
		}
	}
}
