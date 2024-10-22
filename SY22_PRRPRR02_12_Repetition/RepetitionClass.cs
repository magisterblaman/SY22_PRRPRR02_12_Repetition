using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_12_Repetition {
	internal class RepetitionClass {
		// Fält
		private int _age;
		private string _name;
		private string _occupation;

		// Egenskap
		public int Age {
			get {
				return _age;
			}
			set {
				if (value > 0) {
					_age = value;
				}
			}
		}

		// Konstruktor
		public RepetitionClass(int inputAge, string inputName) {
			// Initiera = sätta värden på fält i konstruktorn
			_age = inputAge;
			_name = inputName;
			_occupation = "dhsajhsda";
		}

		// returtyp             parameter
		//      |                  |
		//      v                  v
		public int GetAgeInXYear(int x) {
			int sum = Age + x;

			return sum; // returvärde = värdet som returneras
			// returtyp = datatypen på värdet som returneras
		}
	}
}
