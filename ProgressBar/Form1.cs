using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object TextBox2 { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = textBox2.Text.Length;
            if(karaktersayisi > 0 && karaktersayisi < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label3.Text = "Şifreniz Zayıf";
            }

        else if(karaktersayisi >=4 && karaktersayisi <6)
                {
              progressBar1.Value= 2;
              progressBar1.ForeColor = Color.Yellow;
              label3.Text = "Şifreniz Orta";

            
            }
            else if (karaktersayisi >=6 )
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label3.Text = "Şifreniz Güçlü";

            }
            else
            {
                progressBar1.Value = 0;
            }
        }
        
    }


}

