using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Electric
{
	/// <summary>
	/// Calculations of temperature versus change in conductor resistance and vice versa
	/// </summary>
	public class ResistanceTemperatureChange
	{
		/// <summary>
		/// Calculate new Temperature of Start Temperature, Start Resistance, End Resistance and Material Temperature Coeficient of Resistance
		/// </summary>
		/// <param name="StarTemperature">Temperature on First Resistance</param>
		/// <param name="StartResistance">First Resistance</param>
		/// <param name="EndResistance">Resistance after Resistance Change</param>
		/// <param name="MaterialCoeficient">Material Temperature Coeficient of Resistance</param>
		/// <returns>Wire Temperature on Changed Resistance</returns>
		public static decimal EndTemperature(decimal StarTemperature, decimal StartResistance, decimal EndResistance, decimal MaterialCoeficient)
		{
			return ((EndResistance - StartResistance) / (StartResistance * MaterialCoeficient)) + StarTemperature;
		}

		/// <summary>
		/// Calculate new Resistance of Start Temperature, Start Resistance, End Temperature and Material Temperature Coeficient of Resistance
		/// </summary>
		/// <param name="StartTemperature">Temperature on First Resistance</param>
		/// <param name="StartResistance">First Resistance</param>
		/// <param name="EndTemperature">Temperature after Temperature Changed</param>
		/// <param name="MaterialCoeficient">Material Temperature Coeficient of Resistance</param>
		/// <returns>Wire Resistance on changed Temperature</returns>
		public static decimal ResistanceChange(decimal StartTemperature, decimal StartResistance, decimal EndTemperature, decimal MaterialCoeficient)
		{
			return (StartResistance * MaterialCoeficient * (EndTemperature - StartTemperature)) + StartResistance;
		}

	}
}
