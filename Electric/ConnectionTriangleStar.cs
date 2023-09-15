namespace Calculations.Electric
{
    /// <summary>
    /// Calculations parameters if winding of synchronous/asynchronous motor/generator/transformer change connection between star and triangle
    /// </summary>
    public class ConnectionTriangleStar
    {

        /// <summary>
        /// Calculate voltage in triangle from star voltage
        /// </summary>
        /// <param name="Voltage">Voltage in Star</param>
        /// <returns>Voltage in Triangle</returns>
        public static decimal VoltageStarToTriangle(decimal Voltage)
        {
            return Voltage / (decimal)Math.Sqrt(3);
        }

        /// <summary>
        /// Calculate voltage in star from triangle voltage
        /// </summary>
        /// <param name="Voltage">Voltage in Triangle</param>
        /// <returns>Voltage in Star</returns>
        public static decimal VoltageTriangleToStar(decimal Voltage)
        {
            return Voltage * (decimal)Math.Sqrt(3);
        }

        /// <summary>
        /// Calculate current in triangle from star current
        /// </summary>
        /// <param name="Current">Current in Star</param>
        /// <returns>Current in Triangle</returns>
        public static decimal CurrentStarToTriangle(decimal Current)
        {
            return Current * (decimal)Math.Sqrt(3);
        }

        /// <summary>
        /// Calculate current in star from triangle current
        /// </summary>
        /// <param name="Current">Current in Triangle</param>
        /// <returns>Current in Star</returns>
        public static decimal CurrentTriangleToStar(decimal Current)
        {
            return Current / (decimal)Math.Sqrt(3);
        }



    }
}
