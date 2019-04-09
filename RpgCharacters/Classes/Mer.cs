using System;
using System.Collections.Generic;
using System.Text;

namespace RpgCharacters.Classes
{
	public abstract class Mer : Character
	{
		// Properties
		public virtual bool HasMagic { get; set; } = true;
		public int Intelligence { get; set; }
	}
}
