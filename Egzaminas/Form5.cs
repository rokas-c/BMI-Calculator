using System;
using System.Windows.Forms;

namespace Egzaminas
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double heightCm = double.Parse(textBox1.Text); // Gauna ūgį iš textBox1

                if (heightCm <= 0)
                {
                    MessageBox.Show("Įveskite ūgį CM (0 nėra tinkamas ūgis)"); // Jei parašyta 0 išmeta klaidą
                    return;
                }

                double heightInches = heightCm / 2.54; // Konvertuomas ūgis iš centimetrų į colius

                if (radioButton1.Checked)
                {
                    double idealWeight = 56.2 + 1.41 * (heightInches - 60); // vyrų
                    label2.Text = "Idealus svoris vyrams: " + idealWeight.ToString("F2") + " kg";
                }
                else if (radioButton2.Checked)
                {
                    double idealWeight = 53.1 + 1.36 * (heightInches - 60); // moterų
                    label2.Text = "Idealus svoris moterims: " + idealWeight.ToString("F2") + " kg";
                }
                else
                {
                    MessageBox.Show("Pasirinkite lytį"); // Klaida jei nepasirinkta lytis
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Įveskite ūgį CM"); // Klaida jei parašyta ne skaičiais
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label3.Text = "Vyras";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label3.Text = "Moteris";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
