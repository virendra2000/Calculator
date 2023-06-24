using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        double firstnum;
        string operation;
        public calculator()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var splash = new splash();
            splash.Close();
            Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                txtbox.FillColor = Color.Black;
                this.BackColor = Color.Black;
                btn1.FillColor = Color.Black;
                apptitle.ForeColor = Color.White;
                btnminimize.ForeColor = Color.White;
                btnclose.ForeColor = Color.White;
                themelabel.ForeColor = Color.White;
                txtbox.ForeColor = Color.White;
                btn2.FillColor = Color.Black;
                btn3.FillColor = Color.Black;
                btn4.FillColor = Color.Black;
                btn5.FillColor = Color.Black;
                btn6.FillColor = Color.Black;
                btn7.FillColor = Color.Black;
                btn8.FillColor = Color.Black;
                btn9.FillColor = Color.Black;
                btnzero.FillColor = Color.Black;
                btnmodulas.FillColor = Color.Black;
                btndec.FillColor = Color.Black;
                btnclr.FillColor = Color.Black;
                btnadd.FillColor = Color.Black;
                btnsub.FillColor = Color.Black;
                btnmul.FillColor = Color.Black;
                btndiv.FillColor = Color.Black;
                btnequal.FillColor = Color.Black;
            }
            else
            {
                txtbox.FillColor = Color.White;
                this.BackColor = Color.White;
                btn1.FillColor = Color.DodgerBlue;
                apptitle.ForeColor = Color.Black;
                btnminimize.ForeColor = Color.Black;
                btnclose.ForeColor = Color.Black;
                themelabel.ForeColor = Color.Black;
                txtbox.ForeColor = Color.Black;
                btn2.FillColor = Color.DodgerBlue;
                btn3.FillColor = Color.DodgerBlue;
                btn4.FillColor = Color.DodgerBlue;
                btn5.FillColor = Color.DodgerBlue;
                btn6.FillColor = Color.DodgerBlue;
                btn7.FillColor = Color.DodgerBlue;
                btn8.FillColor = Color.DodgerBlue;
                btn9.FillColor = Color.DodgerBlue;
                btnzero.FillColor = Color.DodgerBlue;
                btnmodulas.FillColor = Color.DodgerBlue;
                btndec.FillColor = Color.DodgerBlue;
                btnclr.FillColor = Color.DodgerBlue;
                btnadd.FillColor = Color.DodgerBlue;
                btnsub.FillColor = Color.DodgerBlue;
                btnmul.FillColor = Color.DodgerBlue;
                btndiv.FillColor = Color.DodgerBlue;
                btnequal.FillColor = Color.DodgerBlue;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "1";
            }
            else
            {
                txtbox.Text = txtbox.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "2";
            }
            else
            {
                txtbox.Text = txtbox.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "3";
            }
            else
            {
                txtbox.Text = txtbox.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "4";
            }
            else
            {
                txtbox.Text = txtbox.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "5";
            }
            else
            {
                txtbox.Text = txtbox.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "6";
            }
            else
            {
                txtbox.Text = txtbox.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "7";
            }
            else
            {
                txtbox.Text = txtbox.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "8";
            }
            else
            {
                txtbox.Text = txtbox.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = "9";
            }
            else
            {
                txtbox.Text = txtbox.Text + "9";
            }
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "0";
        }

        private void btnmodulas_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "%";
            operation = "%";
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "0" && txtbox.Text != null)
            {
                txtbox.Text = ".";
            }
            else
            {
                txtbox.Text = txtbox.Text + ".";
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtbox.Text = "0";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "+";
            operation = "+";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "-";
            operation = "-";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "*";
            operation = "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtbox.Text);
            txtbox.Text = "/";
            operation = "/";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            double secondnum = Convert.ToDouble(txtbox.Text);
            double result;
            if (operation == "+")
            {
                result = firstnum + secondnum;
                txtbox.Text = Convert.ToString(result);
                firstnum = result;
            }
            if (operation == "-")
            {
                result = firstnum - secondnum;
                txtbox.Text = Convert.ToString(result);
                firstnum = result;
            }
            if (operation == "*")
            {
                result = firstnum * secondnum;
                txtbox.Text = Convert.ToString(result);
                firstnum = result;
            }
            if (operation == "/")
            {
                if (secondnum == 0)
                {
                    txtbox.Text = "Cannot Divide By Zero";
                }
                else
                {
                    result = firstnum % secondnum;
                    txtbox.Text = Convert.ToString(result);
                    firstnum = result;
                }
            }
            if (operation == "%")
            {
                if (secondnum == 0)
                {
                    txtbox.Text = "Cannot Divide By Zero";
                }
                else
                {
                    result = firstnum % secondnum;
                    txtbox.Text = Convert.ToString(result);
                    firstnum = result;
                }
                
            }

        }
    }
}
