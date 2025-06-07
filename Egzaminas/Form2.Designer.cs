namespace Egzaminas
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textSvoris = new System.Windows.Forms.TextBox();
            this.textUgis = new System.Windows.Forms.TextBox();
            this.mygSkaiciavimas = new System.Windows.Forms.Button();
            this.labelSvoris = new System.Windows.Forms.Label();
            this.labelUgis = new System.Windows.Forms.Label();
            this.BMIRezultatas = new System.Windows.Forms.Label();
            this.KalorijuRezultatas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textSvoris
            // 
            this.textSvoris.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textSvoris.BackColor = System.Drawing.Color.LavenderBlush;
            this.textSvoris.Location = new System.Drawing.Point(119, 100);
            this.textSvoris.Name = "textSvoris";
            this.textSvoris.Size = new System.Drawing.Size(108, 20);
            this.textSvoris.TabIndex = 0;
            this.textSvoris.TextChanged += new System.EventHandler(this.textSvoris_TextChanged);
            // 
            // textUgis
            // 
            this.textUgis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textUgis.BackColor = System.Drawing.Color.LavenderBlush;
            this.textUgis.Location = new System.Drawing.Point(119, 142);
            this.textUgis.Name = "textUgis";
            this.textUgis.Size = new System.Drawing.Size(108, 20);
            this.textUgis.TabIndex = 1;
            this.textUgis.TextChanged += new System.EventHandler(this.textUgis_TextChanged);
            // 
            // mygSkaiciavimas
            // 
            this.mygSkaiciavimas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mygSkaiciavimas.BackColor = System.Drawing.Color.LavenderBlush;
            this.mygSkaiciavimas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mygSkaiciavimas.ForeColor = System.Drawing.Color.SlateBlue;
            this.mygSkaiciavimas.Location = new System.Drawing.Point(119, 180);
            this.mygSkaiciavimas.Name = "mygSkaiciavimas";
            this.mygSkaiciavimas.Size = new System.Drawing.Size(108, 33);
            this.mygSkaiciavimas.TabIndex = 2;
            this.mygSkaiciavimas.Text = "Skaičiuoti";
            this.mygSkaiciavimas.UseVisualStyleBackColor = false;
            this.mygSkaiciavimas.Click += new System.EventHandler(this.mygSkaiciavimas_Click);
            // 
            // labelSvoris
            // 
            this.labelSvoris.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSvoris.AutoSize = true;
            this.labelSvoris.BackColor = System.Drawing.Color.SlateBlue;
            this.labelSvoris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSvoris.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSvoris.Location = new System.Drawing.Point(16, 99);
            this.labelSvoris.Name = "labelSvoris";
            this.labelSvoris.Size = new System.Drawing.Size(97, 19);
            this.labelSvoris.TabIndex = 3;
            this.labelSvoris.Text = "Svoris (kg):";
            // 
            // labelUgis
            // 
            this.labelUgis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUgis.AutoSize = true;
            this.labelUgis.BackColor = System.Drawing.Color.SlateBlue;
            this.labelUgis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUgis.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUgis.Location = new System.Drawing.Point(35, 141);
            this.labelUgis.Name = "labelUgis";
            this.labelUgis.Size = new System.Drawing.Size(78, 19);
            this.labelUgis.TabIndex = 4;
            this.labelUgis.Text = "Ūgis (m):";
            // 
            // BMIRezultatas
            // 
            this.BMIRezultatas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BMIRezultatas.AutoSize = true;
            this.BMIRezultatas.BackColor = System.Drawing.Color.SlateBlue;
            this.BMIRezultatas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIRezultatas.ForeColor = System.Drawing.SystemColors.Control;
            this.BMIRezultatas.Location = new System.Drawing.Point(16, 238);
            this.BMIRezultatas.Name = "BMIRezultatas";
            this.BMIRezultatas.Size = new System.Drawing.Size(86, 19);
            this.BMIRezultatas.TabIndex = 5;
            this.BMIRezultatas.Text = "Jūsų BMI:";
            // 
            // KalorijuRezultatas
            // 
            this.KalorijuRezultatas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.KalorijuRezultatas.AutoSize = true;
            this.KalorijuRezultatas.BackColor = System.Drawing.Color.SlateBlue;
            this.KalorijuRezultatas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KalorijuRezultatas.ForeColor = System.Drawing.SystemColors.Control;
            this.KalorijuRezultatas.Location = new System.Drawing.Point(16, 276);
            this.KalorijuRezultatas.Name = "KalorijuRezultatas";
            this.KalorijuRezultatas.Size = new System.Drawing.Size(139, 19);
            this.KalorijuRezultatas.TabIndex = 6;
            this.KalorijuRezultatas.Text = "Kalorijų poreikis:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 325);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.SlateBlue;
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atgal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::Egzaminas.Properties.Resources._07845320f2402c5bc921661813d75d4d;
            this.ClientSize = new System.Drawing.Size(891, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KalorijuRezultatas);
            this.Controls.Add(this.BMIRezultatas);
            this.Controls.Add(this.labelUgis);
            this.Controls.Add(this.labelSvoris);
            this.Controls.Add(this.mygSkaiciavimas);
            this.Controls.Add(this.textUgis);
            this.Controls.Add(this.textSvoris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Svorio ir kalorijų programa";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSvoris;
        private System.Windows.Forms.TextBox textUgis;
        private System.Windows.Forms.Button mygSkaiciavimas;
        private System.Windows.Forms.Label labelSvoris;
        private System.Windows.Forms.Label labelUgis;
        private System.Windows.Forms.Label BMIRezultatas;
        private System.Windows.Forms.Label KalorijuRezultatas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
