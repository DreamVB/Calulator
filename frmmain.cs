using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathPro
{
    public partial class frmmain : Form
    {
        private bool m_isOp = false;
        private double m_Oprand1 = 0.0;
        private double m_Oprand2 = 0.0;
        private string m_operator;

        public frmmain()
        {
            InitializeComponent();
        }

        private string Operator
        {
            get
            {
                return m_operator;
            }
            set
            {
                m_operator = value;
            }
        }

        private double OperandOne
        {
            get
            {
                return m_Oprand1;
            }
            set
            {
                m_Oprand1 = value;
            }
        }

        private double OperandTwo
        {
            get
            {
                return m_Oprand2;
            }
            set
            {
                m_Oprand2 = value;
            }
        }

        private bool IsOperator
        {
            get
            {
                return m_isOp;
            }
            set
            {
                m_isOp = value;
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text.ToUpper().Equals("NAN"))
            {
                txtDisplay.Clear();
            }
            if (txtDisplay.Text.Equals("0") || IsOperator)
            {
                txtDisplay.Text = string.Empty;
            }
            
            IsOperator = false;
            txtDisplay.Text += btn.Text;
        }

        private void ButDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdBackspace_Click(object sender, EventArgs e)
        {
            int len = txtDisplay.TextLength;
            len--;

            if (len <=0)
            {
                txtDisplay.Text = "0";
            }
            else
            {
                //Remove one chat from the text box
                txtDisplay.Text = txtDisplay.Text.Remove(len, 1);
            }

        }

        private void ButPlus_Click(object sender, EventArgs e)
        {
            Button op_but = (Button)sender;

            if (!IsOperator)
            {
                OperandOne = double.Parse(txtDisplay.Text);
                IsOperator = true;
                Operator = op_but.Text;
            }
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            IsOperator = false;
            Operator = string.Empty;
            OperandOne = 0.0;
            OperandTwo = 0.0;
            txtDisplay.Text = "0";
        }

        private void txtDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.Invalidate();
        }

        private void ButEquals_Click(object sender, EventArgs e)
        {
            OperandTwo = double.Parse(txtDisplay.Text);
            double RetVal = 0.0;

            switch (Operator)
            {
                case "+":
                    RetVal = (OperandOne + OperandTwo);
                    break;
                case "-":
                    RetVal = (OperandOne - OperandTwo);
                    break;
                case "*":
                    RetVal = (OperandOne * OperandTwo);
                    break;
                case "/":
                    RetVal = (OperandOne / OperandTwo);
                    break;
                case "MOD":
                    RetVal = (OperandOne % OperandTwo);
                    break;
            }
            txtDisplay.Text = RetVal.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    this.ButPlus.PerformClick();
                    break;
                case '-':
                    this.ButSubtract.PerformClick();
                    break;
                case '*':
                    this.ButMult.PerformClick();
                    break;
                case '/':
                    this.ButDiv.PerformClick();
                    break;
                case '=':
                    this.ButEquals_Click(sender, e);
                    break;
                case '0':
                    this.Btn0.PerformClick();
                    break;
                case '1':
                    this.Btn1.PerformClick();
                    break;
                case '2':
                    this.Btn2.PerformClick();
                    break;
                case '3':
                    this.Btn3.PerformClick();
                    break;
                case '4':
                    this.Btn4.PerformClick();
                    break;
                case '5':
                    this.Btn5.PerformClick();
                    break;
                case '6':
                    this.Btn6.PerformClick();
                    break;
                case '7':
                    this.Btn7.PerformClick();
                    break;
                case '8':
                    this.Btn8.PerformClick();
                    break;
                case '9':
                    this.Btn9.PerformClick();
                    break;
                case '.':
                    this.ButDot_Click(sender, e);
                    break;
            }
        }

        private void cmdFloor_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double RetVal = 0.0;

            switch (btn.Text.ToUpper())
            {
                case "OFF":
                    //Turn off calulator
                    Application.Exit();
                    break;
                case "LOG":
                    RetVal = Math.Log(double.Parse(txtDisplay.Text));
                    break;
                case "SQRT":
                    RetVal = Math.Sqrt(double.Parse(txtDisplay.Text));
                    break;
                case "SINH":
                    RetVal = Math.Sinh(double.Parse(txtDisplay.Text));
                    break;
                case "SIN":
                    RetVal = Math.Sin(double.Parse(txtDisplay.Text));
                    break;
                case "X^2":
                    RetVal = Math.Pow(2,double.Parse(txtDisplay.Text));
                    break;
                case "LN X":
                    RetVal = Math.Log(double.Parse(txtDisplay.Text));
                    break;
                case "COSH":
                    RetVal = Math.Cosh(double.Parse(txtDisplay.Text));
                    break;
                case "COS":
                    RetVal = Math.Cos(double.Parse(txtDisplay.Text));
                    break;
                case "X^3":
                    RetVal = Math.Pow(3, double.Parse(txtDisplay.Text));
                    break;
                case "%":
                    RetVal = double.Parse(txtDisplay.Text) / 100; 
                    break;
                case "TANH":
                    RetVal = Math.Tanh(double.Parse(txtDisplay.Text));
                    break;
                case "TAN":
                    RetVal = Math.Tan(double.Parse(txtDisplay.Text));
                    break;
                case "1/X":
                    RetVal = 1 / RetVal;  
                    break;
                case "CEIL":
                    RetVal = Math.Ceiling(double.Parse(txtDisplay.Text));
                    break;
                case "EXP":
                    RetVal = Math.Exp(double.Parse(txtDisplay.Text));
                    break;
                case "PI":
                    RetVal = Math.PI;
                    break;
                case "FLOOR":
                    RetVal = Math.Floor(double.Parse(txtDisplay.Text));
                    break;
            }
            //Set text field with value.
            txtDisplay.Text = RetVal.ToString();
        }

        private void cmdBinMod_Click(object sender, EventArgs e)
        {
            if (!IsOperator)
            {
                OperandOne = double.Parse(txtDisplay.Text);
                IsOperator = true;
                Operator = "MOD";
            }
        }

        private void ButPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }
    }
}
