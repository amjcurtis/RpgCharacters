using System;
using System.Collections.Generic;
using System.Text;

namespace RpgCharacters.Classes
{
	public abstract class Character
	{
		// Properties
		public int HitPoints { get; set; }
		public int Experience { get; set; }
		public int Level { get; set; }

		// Abstract method
		public abstract int LevelUp();
		
		// Virtual method
		public virtual bool IsAlive()
		{
			if (HitPoints > 0)
			{
				return true;
			}
			return false;
		}
	}
}
