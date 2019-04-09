using System;
using System.Collections.Generic;
using System.Text;

namespace RpgCharacters.Classes
{
	public class Zombie : Mer
	{
		public override int LevelUp()
		{
			if (Experience > 1000)
			{
				Experience = 0;
				return Level += 1;
			}
			else
			{
				return Level;
			}
		}

		public override bool IsAlive()
		{
			return false;
		}

		public override bool HasMagic { get; set; } = false;

	}
}
