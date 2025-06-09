using System;

namespace Egzaminas
{

    // Skaičiuoja kūno masės indeksą (KMI)
    public class BMISkaiciuotuvas : Skaiciavimas
    {
        /// <summary>
        /// Skaičiuoja kūno masės indeksą pagal svorį ir ūgį
        /// </summary>
        /// <param name="svoris">Svoris, kilogramais</param>
        /// <param name="ugis">Ūgis, metrais</param>
        /// <returns>Kūno masės indeksas</returns>
        public override double Skaiciuoti(double svoris, double ugis)
        {
            return svoris / (ugis * ugis);
        }
        // ----------------------------------------------------------
        public override double Skaiciuoti(double svoris)
        {
            throw new NotImplementedException();
        }
    }
}
