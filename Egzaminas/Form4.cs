using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Egzaminas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            RodytiFaila(); // Paleidzia metoda ir parodo duomenis richTextBox1
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Rodo failo duomenis richTexhBox1 (Metodas)
        private void RodytiFaila()
        {
            {
                string filePath = "rezultatai.txt"; // Nurodome failo pavadinimą ir vietą
                if (File.Exists(filePath)) // Patikrina ar failas egzistuoja
                {
                    richTextBox1.Text = File.ReadAllText(filePath); // Jei taip perskaito visa faila su ReadALlText ir ji parodo textboxe
                }
                else
                {
                    richTextBox1.Text = "Failas nerastas."; // Jei failas neegzistuoja ismeta pranesima "Failas nerastas"
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Uždaro langelį
        }
    }
}
