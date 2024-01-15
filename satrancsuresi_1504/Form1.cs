using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satrancsuresi_1504
{
    public partial class Form1 : Form
    {
        int surebeyaz = 10;
        int suresiyah = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSıhaSure_Click(object sender, EventArgs e)
        {
            timerSiyah.Start();
            this.lblSiyah.ForeColor = Color.Black;
        }

        private void timerBeyaz_Tick(object sender, EventArgs e)
        {
            surebeyaz--;
            lblBeyaz.Text=surebeyaz.ToString();
            if(surebeyaz < 0)
            {
                timerBeyaz.Stop();
                lblmesaj.Text = "siyah kazandi";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBeyazSure_Click(object sender, EventArgs e)
        {
            timerBeyaz.Start();

            this.lblBeyaz.ForeColor= Color.White;
           
        }

        private void timerSiyah_Tick(object sender, EventArgs e)
        {
            suresiyah--;
            lblSiyah.Text=suresiyah.ToString();
           if(suresiyah < 0)
            {
                timerSiyah.Stop();
                lblmesaj.Text = "beyaz kazandı";
            }
        }
    }
}
