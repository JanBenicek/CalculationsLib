namespace Calculations.Electric
{
    public class OhmLaw
    {

        /// <summary>
        /// Calculate Resistance from Voltage and Current
        /// </summary>
        /// <param name="Voltage">Voltage</param>
        /// <param name="Current">Current</param>
        /// <returns>Resistance</returns>
        public static decimal Resistance(decimal Voltage, decimal Current)
        {
            return Voltage / Current;
        }

		/// <summary>
		/// Calculate Voltage from Resistance and Current
		/// </summary>
		/// <param name="Resistance">Resistance</param>
		/// <param name="Current">Current</param>
		/// <returns>Voltage</returns>
		public static decimal Voltage(decimal Resistance, decimal Current)
        {
            return Current * Resistance;
        }

		/// <summary>
		/// Calculate Current from Voltage and Resistance
		/// </summary>
		/// <param name="Voltage">RVoltage</param>
		/// <param name="Resistance">Resistance</param>
		/// <returns>Current</returns>
		public static decimal Current(decimal Voltage, decimal Resistance) 
        { 
            return Voltage / Resistance;
        }

    }
}