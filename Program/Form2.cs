using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Egzaminas
{
    public partial class Form2 : Form
    {
        // Žodynas rezultatų saugojimui
        private readonly Dictionary<string, double> rezultatai = new Dictionary<string, double>();

        // Formos konstruktorius
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Paspaudus mygtuką "Skaičiuoti" skaičiuoja BMI ir dienos kalorijų poreikį
        /// </summary>
        private void mygSkaiciavimas_Click(object sender, EventArgs e)
        {
            try
            {
                // Gauti svorį ir ūgį
                double svoris = GautiSvori();
                double ugis = GautiUgi();

                // Apskaičiuoja BMI ir kalorijų poreikį
                double bmi = SkaiciuotiBMI(svoris, ugis);
                double kalorijos = SkaiciuotiKalorijas(svoris);

                // Parodo rezultatus ir įrašo į failą
                RodytiRezultata(bmi, kalorijos);
                IssaugotiRezultatus(svoris, ugis, bmi, kalorijos);
                IrasytiIFaila();
            }
            catch (FormatException)
            {
                // Išveda klaida, jei duomenys buvo suvesti neteisingai
                MessageBox.Show("įveskite teisingus skaičius");
            }
        }

        private double SkaiciuotiBMI(double svoris, double ugis)
        {
            Skaiciavimas bmiSkaiciavimas = new BMISkaiciuotuvas();
            return bmiSkaiciavimas.Skaiciuoti(svoris, ugis);
        }

        private double SkaiciuotiKalorijas(double svoris)
        {
            Skaiciavimas kalorijuSkaiciavimas = new KalorijuSkaiciavimas1();
            return kalorijuSkaiciavimas.Skaiciuoti(svoris);
        }

        /// <summary>
        /// Gauna svorį iš (TextBox)
        /// </summary>
        private double GautiSvori()
        {
            return double.Parse(textSvoris.Text);
        }

        /// <summary>
        /// Gauna ūgį iš (TextBox)
        /// </summary>
        private double GautiUgi()
        {
            return double.Parse(textUgis.Text);
        }

        /// <summary>
        /// Rodo rezultatus
        /// </summary>
        private void RodytiRezultata(double bmi, double kalorijos)
        {
            // Parodo rezultata
            BMIRezultatas.Text = "Jūsų BMI: " + bmi.ToString("F2");
            KalorijuRezultatas.Text = "Kalorijų poreikis: " + kalorijos.ToString("F2") + " kcal";
        }

        /// <summary>
        /// Rezultatus išsaugo į žodyną
        /// </summary>
        private void IssaugotiRezultatus(double svoris, double ugis, double bmi, double kalorijos)
        {
            // Išvalo rezultatų žodyną ir įrašo naujus rezultatus
            rezultatai.Clear();
            rezultatai["Svoris"] = svoris;
            rezultatai["Ūgis"] = ugis;
            rezultatai["BMI"] = bmi;
            rezultatai["Kalorijų poreikis"] = kalorijos;
        }

        /// <summary>
        /// Rezultatus įrašo į failą
        /// </summary>
        private void IrasytiIFaila()
        {
            // Įrašo rezultatus į failą
            using (StreamWriter file = new StreamWriter("rezultatai.txt", true))
            {
                file.WriteLine("Svoris\tŪgis\tBMI\tKalorijų poreikis");
                file.WriteLine($"{rezultatai["Svoris"]}\t{rezultatai["Ūgis"]}\t{rezultatai["BMI"]:F2}\t{rezultatai["Kalorijų poreikis"]:F2}");
            }
        }

        // Nenaudojami, bet reikalingi dėl interface
        // ------------------------------------------------------------
        private void textSvoris_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void textUgis_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // ------------------------------------------------------------
    }
}
