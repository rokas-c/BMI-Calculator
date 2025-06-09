using System;

namespace Egzaminas
{
    /// <summary>
    /// Skaičiuoja dienos kalorijų poreikį pagal svorį
    /// </summary>
    public class KalorijuSkaiciavimas1 : Skaiciavimas
    {
//-------------------------------------------------------------------------
        public override double Skaiciuoti(double svoris, double ugis)
        {
            throw new NotImplementedException();
        }
//-------------------------------------------------------------------------

        /// <summary>
        /// Skaičiuoja dienos kalorijų poreikį pagal svorį (SKAICIU PLACEHOLDER)
        /// </summary>
        /// <param name="svoris">Svoris, kilogramais</param>
        /// <returns>Dienos kalorijų poreikis</returns>
        public override double Skaiciuoti(double svoris)
        {
            return 24 * svoris;
        }
    }
}
