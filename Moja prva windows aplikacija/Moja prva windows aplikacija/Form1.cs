using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moja_prva_windows_aplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            try { 
            int brojA, brojB, zbroj;
            brojA = Convert.ToInt32(txtUnosBrojaA.Text);
            brojB = Convert.ToInt32(txtUnosBrojaB.Text);
            zbroj = brojA + brojB;

            txtRez.Text =Convert.ToString(zbroj);
                }
            catch (Exception ex)
            {
                string text= "Molim upisati broj. \n" + ex.Message;
                string Naslov ="Pogrešan unos";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon= MessageBoxIcon.Error;

                MessageBox.Show(text, Naslov, buttons, icon);
            }
        }
    }
}
