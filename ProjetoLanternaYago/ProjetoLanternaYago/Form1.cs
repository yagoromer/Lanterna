using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoLanternaYago
{
    public partial class Lanterna : Form
    {
        public Lanterna()
        {
            InitializeComponent();
        }
        int s = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s > 0)
            {
                if (s>=70)
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = $"{s}" + " %";
                    progressBar1.Value = s;
                }
                if (s < 70)
                {
                    label1.ForeColor = Color.Yellow;
                    label1.Text = $"{s}" + " %";
                    progressBar1.Value = s;

                }
                if(s < 40)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = $"{s}" + " %";
                    progressBar1.Value = s;
                }
                label1.Text = $"{s}"+" %";
                
                label2.ForeColor = Color.Yellow;
            }
            else if(s==0){
                label1.Text = "Bateria acabou!!";
                label2.ForeColor = Color.Black;
                progressBar1.Value = 0;
            }
            progressBar1.Value = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            s = 100;
            label1.Text = $"{s}" + " %";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
