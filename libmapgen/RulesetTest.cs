using NUnit.Framework;
using System;

namespace libmapgen
{
	[TestFixture()]
	public class RulesetTest
	{
		[Test()]
		public void NewRuleset ()
		{
			Ruleset ruleset = new Ruleset ();

			Assert.AreEqual (0, ruleset.passes.Count);

			Assert.DoesNotThrow (delegate { ruleset.generate(); });
		}

		[Test()]
		public void NewRulesetWithGenerator ()
		{
			Ruleset ruleset = new Ruleset (new RandomHeightmap(12, 12, 0.0f, 1.0f));

			Assert.AreEqual (0, ruleset.passes.Count);
			Assert.IsInstanceOf (typeof(RandomHeightmap), ruleset.generator);

			Assert.DoesNotThrow (delegate { ruleset.generate(); });
		}
	}
}

