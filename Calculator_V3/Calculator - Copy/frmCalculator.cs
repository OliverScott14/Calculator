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
    public partial class frmCalculator : Form
    {
        double? input = 0;
        double? result;
        double? operand1 = null;
        double? operand2 = null;
        bool _decimalOn = false;
        public int operandGo;
        bool MinusOn = false;
        private Operation currentOperation = Operation.NoneSelected;
        public enum Operation
        {
            NoneSelected = 0,
            SquareRoot = 1,
            Square = 2,
            Power = 3,
            Reciprocal = 5,

            Division = 4,
            Multiplication = 3,
            Subtraction = 2,
            Addition = 1
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
        }
        public frmCalculator()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(frmCalculator_KeyPress);
        }
       
        
        void operate()
        {

            if (operand1 == null)
            {
                operand1 = double.Parse(txtInputOutput.Text);
                lblHistory.Text = operand1.ToString();
                txtInputOutput.Clear();
                // MessageBox.Show("Operand1 = " + num.ToString());

            }
            else
            {
                operand2 = double.Parse(txtInputOutput.Text);
                var a = operand1 + operand2;
                MessageBox.Show(a.ToString());
            }
            switch (operandGo)
            {
                case 1:  // + 
                    MessageBox.Show("addition:");
                    result = operand1 + operand2;
                    lblHistory.Text = " + ";

                    //lblHistory.Text += ;
                    break;
                case 2: // / 
                    result = operand1 / operand2;

                    lblHistory.Text = operand1.ToString() + " - " + operand2.ToString() + " = " + result.ToString();
                    break;
                default:
                    break;

            }
            lblHistory.Text = operand1.ToString() + " + " + operand2.ToString() + " = " + result.ToString();
            MessageBox.Show("Done:");

            // txtInputOutput.Text = result.ToString();
            //operandGo = 0;

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
            input = 0;
            result = 0;
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
         

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {

            operandGo = 1;
            operate();
            

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            operandGo = 2;
            operate();
            txtInputOutput.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operandGo = 3;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operandGo = 4;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            operandGo = 5;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            operandGo = 6;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            operandGo = 7;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            operandGo = 8;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (MinusOn == false)
            { MinusOn = true; }

        }

        private void btnEquality_Click(object sender, EventArgs e)
        {

          



            lblHistory.Text = (" = " + result.ToString());
            txtInputOutput.Text = result.ToString();
            MinusOn = false;
        }
    }
}
