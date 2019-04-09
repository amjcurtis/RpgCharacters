using System;
using System.Collections.Generic;
using System.Text;

namespace RpgCharacters.Classes
{
	class Elf : Mer
	{
		public override int LevelUp()
		{
			if (Experience > 50)
			{
				Experience = 0;
				return Level += 1;
			}
			else
			{
				return Level;
			}
		}
	}
}
