using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result;

        //bool _decimalOn = false;
        //public int operandGo;
        bool MinusOn = false;
 
        private void frmCalculator_Load(object sender, EventArgs e)
        {
        }
        public frmCalculator()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(frmCalculator_KeyPress);
        }
       
       

        void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {

            //MessageBox.Show("Form.KeyPress: '" + e.KeyChar.ToString() + "' pressed.");

            if (e.KeyChar >= 48 && e.KeyChar <= 57)//0x30
            {
                if (txtInputOutput.Text == "0")
                { txtInputOutput.Clear(); }
               

                switch (e.KeyChar)//(int)e.KeyChar)
                {
                    case '0':
                        btnZero_Click(sender, e);
                        break;
                    case '1':
                        btnOne_Click(sender, e);
                        break;
                    case '2':
                        btnTwo_Click(sender, e);
                        break;
                    case '3':
                        btnThree_Click(sender, e);
                        break;
                    case '4':
                        btnFour_Click(sender, e);
                        break;
                    case '5':
                        btnFive_Click(sender, e);
                        break;
                    case '6':
                        btnSix_Click(sender, e);
                        break;
                    case '7':
                        btnSeven_Click(sender, e);
                        break;
                    case '8':
                        btnEight_Click(sender, e);
                        break;
                    case '9':
                        btnNine_Click(sender, e);
                        break;
                    default:
                        MessageBox.Show("Form.KeyPress: '" +
                                        e.KeyChar.ToString() + "' consumed.");
                        e.Handled = true;
                        break;
                }
            }
        }

        void sendNum(double num)
        {
            if (MinusOn == true)
            { 
                num = num * -1; 
               
            }
            input += num.ToString();
            txtInputOutput.Text += num.ToString();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(0);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(1);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(2);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(3);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(4);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(5);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {       
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(6);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(7);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(8);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtInputOutput.Text == "0")
            { txtInputOutput.Clear(); }
            sendNum(9);
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            
            txtInputOutput.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtInputOutput.Clear();
            //input = 0;
            result = 0;
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
         

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            lblLastinput.Text += input + operation;
            input = string.Empty;
            txtInputOutput.Clear();

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            lblLastinput.Text += input + operation;
            input = string.Empty;
            txtInputOutput.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            lblLastinput.Text += input + operation;
            input = string.Empty;
            txtInputOutput.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            lblLastinput.Text += input + operation;
            input = string.Empty;
            txtInputOutput.Clear();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            txtInputOutput.Clear();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '@';
            lblLastinput.Text += input + operation;
            input = string.Empty;
            txtInputOutput.Clear();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '^';
            lblLastinput.Text += input + operation;
            input = string.Empty;
            txtInputOutput.Clear();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            txtInputOutput.Clear();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
         //   if (MinusOn == false)
         //   { MinusOn = true; }

        }

        private void btnEquality_Click(object sender, EventArgs e)
        {
            
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            txtInputOutput.Clear();
         
            if (operation == '+')
            {
                result = num1 + num2;
                txtInputOutput.Text = result.ToString();
            }
            else if (operation == '@')
            {
                double x = 0;
                for (int i = 0; i < num2; i++)
                {
                    x = (num1 * num1);
                }
                result = x;
            }
            else if (operation == '^')
            {

                result = num1 * num1;

                txtInputOutput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtInputOutput.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtInputOutput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtInputOutput.Text = result.ToString();
                }
                else
                {
                    txtInputOutput.Text = "DIV/Zero!";
                }
            }
            num1 = result;

       


             //   lblHistory.Text = (" = " + result.ToString());
           // txtInputOutput.Text = result.ToString();
           // MinusOn = false;
        }
    }
}
