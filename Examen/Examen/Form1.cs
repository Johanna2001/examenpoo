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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cargammos los valores al combobox
            cboproducto.Items.Add("Seleccione un producto");
            cboproducto.Items.Add("Smart Tv LG 49");
            cboproducto.Items.Add("Blue Ray Sonu");
            cboproducto.Items.Add("Laptop Lenovo");
            cboproducto.Items.Add("Play Station ");
            
            //bloqueando controles
            txtTD.ReadOnly = true;
            txtpre.ReadOnly = true;
            txtSub.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtIGV.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }

        void calcular()
        {
            double pre = 0, igv = 0, des = 0, sub = 0, tot = 0;
            int can = 0;

            can = Convert.ToInt32(txtCan.Text);
            int indice = cboproducto.SelectedIndex;
            switch (indice)
            {
                case 1:
                    pre = 1200;
                    break;
                case 2:
                    pre = 580;
                    break;
                case 3:
                    pre = 2850;
                    break;
                case 4:
                    pre = 4200;
                    break;
                case 5:
                    pre = 3800;
                    break;
                default:
                    pre = 0;
                    break;

            }

            sub = pre * can;
            if (rbF.Checked == true)
            {
                igv = sub * 0.18;
            }
            else
            {
                igv = 0;
            }


            if (chkDes.Checked == true)
            {
                des = sub * 0.05;
            }
            else
            {
                des = 0;
            }
            tot = sub + igv - des;

            txtSub.Text = "" + sub;
            txtIGV.Text = "" + igv;
            txtpre.Text = "" + pre;
            txtTD.Text = "" + des;
            txtTotal.Text = "" + tot;

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            cboproducto.SelectedIndex = 0;
            txtpre.Text = "";
            txtCan.Text = "";
            txtSub.Text = "";
            rbF.Checked = false;
            rbB.Checked = false;
            txtIGV.Text = "";
            txtTD.Text = "";
            txtTotal.Text = "";
            chkDes.Checked = false;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rbF.Checked = false;
            rbB.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}