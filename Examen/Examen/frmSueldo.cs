using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana03
{
    public partial class frmSueldo : Form
    {
        public frmSueldo()
        {
            InitializeComponent();
        }

        private void frmSueldo_Load(object sender, EventArgs e)
        {
            //Bloquear los controles
            txtBon1.ReadOnly = true;
            txtBon2.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtDes.ReadOnly = true;
            txtGrati.ReadOnly = true;
            cboMes.Items.Add("Seleccione un mes");
            cboMes.Items.Add("Enero");

            cboMes.Items.Add("Febrero");
            cboMes.Items.Add("Marzo");
            cboMes.Items.Add("Abril");
            cboMes.Items.Add("Mayo");
            cboMes.Items.Add("Junio");
            cboMes.Items.Add("Julio");
            cboMes.Items.Add("Septiembre");
            cboMes.Items.Add("Octubre");
            cboMes.Items.Add("Noviembre");
            cboMes.Items.Add("Diciembre");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        void limpiar()
        {
            txtSueldo.Text = "";
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
            rbM.Checked = false;
            rbT.Checked = false;
            rbN.Checked = false;
            txtBon1.Text = "";
            txtBon2.Text = "";
            txtDes.Text = "";
            cboMes.SelectedIndex = 0;
            txtGrati.Text = "";
            txtTotal.Text = "";
            txtSueldo.Focus();
        }
        void calcular()
        {
            double sue = 0, bon1 = 0, bon2 = 0, gra = 0, des = 0, tot = 0;
            String mes = "";
            sue = Convert.ToDouble(txtSueldo.Text);
            mes = cboMes.SelectedItem.ToString();
            if (rbM.Checked == true)
            {
                bon1 = sue * 0.07;
            }else if (rbT.Checked == true)
            {
                bon1 = sue * 0.03;
            }else if (rbN.Checked == true)
            {
                bon1 = sue * 0.09;
            }
            else
            {
                bon1 = 0;
            }

            if (rbA.Checked == true)
            {
                bon2 = sue * 0.03;
                des = sue * 0.01;
            }
            else if (rbB.Checked == true)
            {
                bon2 = sue * 0.05;
                des = sue * 0.03;
            }else if (rbC.Checked == true)
            {
                bon2 = sue * 0.07;
                des = sue * 0.05;
            }else if (rbD.Checked == true)
            {
                bon2 = sue * 0.09;
                des = sue * 0.07;
            }

            switch (mes)
            {
                case "Julio":
                    gra = sue;
                    break;
                case "Diciembre":
                    gra = sue;
                    break;
                default:
                    gra = 0;
                    break;
            }
            tot = sue + bon1 + bon2 + gra - des;
            txtBon1.Text = ""+bon1;
            txtBon2.Text = "" + bon2;
            txtTotal.Text = "" + tot;
            txtDes.Text = "" + des;
            txtGrati.Text = "" + gra;


                









        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
