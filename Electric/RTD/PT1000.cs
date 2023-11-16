using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Electric.RTD
{
    public static class PT1000
    {
        private static readonly decimal KoeficientA = 0.0039083M;
        private static readonly decimal KoeficientB = -0.0000005775M;
        private static readonly decimal KoeficientC = -0.000000000004183M;


        /// <summary>
        /// Recalculate temperature to PT1000 Resistance
        /// </summary>
        /// <param name="temperature">Temperature in °C</param>
        /// <returns>Resistance PT1000</returns>
        public static decimal TemperatureToResistance(decimal temperature)
        {
            if (temperature < 0)
            {
                return 1000 * (1 + KoeficientA * temperature + KoeficientB * (decimal)Math.Pow((double)temperature, 2) + KoeficientC * (decimal)Math.Pow((double)temperature, 3) * (temperature - 100));
            }
            else
            {
                return 1000 * (1 + KoeficientA * temperature + KoeficientB * (decimal)Math.Pow((double)temperature, 2));
            }
        }

        /// <summary>
        /// Recalculate PT1000 resistance to Temperature
        /// </summary>
        /// <param name="resistance">Resistance PT1000</param>
        /// <returns>Temperature in °C</returns>
        public static double ResistanceToTemperature(double resistance)
        {
            return (Math.Sqrt((double)KoeficientB * (resistance / 10) - 100 * (double)KoeficientB + 25 * Math.Pow((double)KoeficientA, 2)) - 5 * (double)KoeficientA) / (double)(10 * KoeficientB);
        }

        /// <summary>
        /// Recalculate PT1000 resistance to Temperature
        /// </summary>
        /// <param name="resistance">Resistance PT1000</param>
        /// <returns>Temperature in °C</returns>
        public static double ResistanceToTemperature(decimal resistance)
        {
            return ResistanceToTemperature((double)resistance);
        }

    }
}
