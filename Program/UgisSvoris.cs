using System;

namespace Egzaminas
{
    /// <summary>
    /// Nurodo svori ir ūgi
    /// </summary>
    public abstract class UgisSvoris
    {
        /// <summary>
        /// Gauna arba nustato svorį
        /// </summary>
        public double Svoris { get; set; }

        /// <summary>
        /// Gauna arba nustato ūgį
        /// </summary>
        public double Ūgis { get; set; }

        /// <summary>
        /// Skaičiuoja sveikatos rodiklius
        /// </summary>
        /// <returns>Skaičiuoja sveikatos rodiklį</returns>
        public abstract double Skaičiuoti();
    }
}
