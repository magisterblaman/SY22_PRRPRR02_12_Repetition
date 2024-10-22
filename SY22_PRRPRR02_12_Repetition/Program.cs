using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_12_Repetition {
	internal class Program {
		static void Main(string[] args) {
			// Instantiera = skapa ett objekt (new Klassnamn(...))
			// Objekt = repetition i det här fallet
			RepetitionClass repetition = new RepetitionClass(20, "Hannes");

			Console.WriteLine(repetition.GetAgeInXYear(60));
		}
	}
}
