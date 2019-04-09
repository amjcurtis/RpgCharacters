using System;
using System.Collections.Generic;
using System.Text;

namespace RpgCharacters.Classes
{
	class Human : Men
	{
		public override int LevelUp()
		{
			if (Experience > 100)
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
