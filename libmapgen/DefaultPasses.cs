using System.Collections.Generic;
namespace libmapgen
{
	public sealed class DefaultPasses
	{
		public static List<System.Type> get()
		{
			List<System.Type> list = new List<System.Type>();
			list.Add (typeof(DummyPass));
			return list;
		}
	}
}