using System;
using RpgCharacters.Classes;

namespace RpgCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Zombie zombie = new Zombie();
			Console.WriteLine(zombie.HasMagic);
		}
	}
}
