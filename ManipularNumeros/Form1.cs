using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse
            //int num;
            //bool res = int.TryParse("1985alow", out num);

            //int.TryParse("1985alow", out num);

            //if (int.TryParse("1985", out num))
            //{
            //    lblResultado.Text = num.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Erro na conversão";
            //}
            #endregion

            //double num = 120.5524;
            //lblResultado.Text = num.ToString("#.00");

            int num = 254;
            //lblResultado.Text = num.ToString("X"); // Hexadecimal
            //lblResultado.Text = num.ToString("D");  // Decimal

            lblResultado.Text = num.ToString("D5"); // Hex

            //lblResultado.Text = num.ToString("D");  // Decimal
            //lblResultado.Text = num.ToString("C");  // Monetario


        }
    }
}
