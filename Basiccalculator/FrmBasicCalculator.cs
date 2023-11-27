using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import the private assembly created
using CalculatorPrivateAssembly;

namespace Basiccalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float firstNum = float.Parse(txtInput1.Text);
            float secondNum = float.Parse(txtInput2.Text);

            if (cbOperator.Text == "+")
            {
                lblTotal.Text = BasicComputation.Add(firstNum, secondNum).ToString();
            }
            else if (cbOperator.Text == "-")
            {
                lblTotal.Text = BasicComputation.Subtract(firstNum, secondNum).ToString();
            }
            else if (cbOperator.Text == "*")
            {
                lblTotal.Text = BasicComputation.Multiply(firstNum, secondNum).ToString();
            }
            else if (cbOperator.Text == "/")
            {
                lblTotal.Text = BasicComputation.Divide(firstNum, secondNum).ToString();
            }
        }
    }
}
