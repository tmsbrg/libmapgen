using System;
using System.Collections.Generic;

namespace libmapgen
{
	[Serializable()]
	public class Ruleset
	{
		public IInitialMapGenerator generator;
		public List<IMapPass> passes;

		public Ruleset ()
		{
		}

		public MapArea generate()
		{
			MapArea map = generator.generate ();
			foreach (var pass in passes)
			{
				pass.call (map);
			}
			return map;
		}
	}
}

