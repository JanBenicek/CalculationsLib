using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Meteorology
{
    public class TemperatureTransfer
    {
        /// <summary>
        /// Transfer °C(celsius) to °K(Kelvin)
        /// </summary>
        /// <param name="celsius">Temperature in °Celsius</param>
        /// <returns>Temperature in °Kelvin</returns>
        public static decimal CelsiusToKelvin(decimal celsius)
        {
            return celsius + (decimal)273.15;
        }

        /// <summary>
        /// Transfer °K(Kelvin) to °C(Celsius)
        /// </summary>
        /// <param name="kelvin">Temperature in °Kelvin</param>
        /// <returns>Temperature in °Celsius</returns>
        public static decimal KelvinToCelsius(decimal kelvin)
        {
            return kelvin - (decimal)273.15;
        }

        /// <summary>
        /// Transfer °C(Celsius) to °F(Fahrenheit)
        /// </summary>
        /// <param name="celsius">Temperature in °Celsius</param>
        /// <returns>Temperature in °Fahrenheit</returns>
        public static decimal CelsiusToFahrenheit(decimal celsius)
        {
            return (celsius * (decimal)1.8) + 32;
        }

        /// <summary>
        /// Transfer °F(Fahrenheit) to °C(Celsius)
        /// </summary>
        /// <param name="fahrenheit">Temperature in °Fahrenheit</param>
        /// <returns>Temperature in °Celsius</returns>
        public static decimal FahrenheitToCelsius(decimal fahrenheit)
        {
            return (fahrenheit - 32) / (decimal)1.8;
        }

        /// <summary>
        /// Transfer °K(Kelvin) to °F(Fahrenheit)
        /// </summary>
        /// <param name="kelvin">Temperature in °Kelvin</param>
        /// <returns>Temperature in °Fahrenheit</returns>
        public static decimal KelvinToFahrenheit(decimal kelvin)
        {
            return CelsiusToFahrenheit(KelvinToCelsius(kelvin));
        }

        /// <summary>
        /// Transfer °F(Fahrenheit) to °K(Kelvin)
        /// </summary>
        /// <param name="fahrenheit">Temperature in °Fahrenheit</param>
        /// <returns>Temperature in °Kelvin</returns>
        public static decimal FahrenheitToKelvin(decimal fahrenheit)
        {
            return CelsiusToKelvin(FahrenheitToCelsius(fahrenheit));
        }

    }
}
