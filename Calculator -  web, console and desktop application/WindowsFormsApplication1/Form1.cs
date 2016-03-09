using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int x;

            x = int.Parse(txtFactorial.Text);

            CaculatorWindowsForms.CaculatorServiceReference.CaculatorWebServiceSoapClient calc = new CaculatorWindowsForms.CaculatorServiceReference.CaculatorWebServiceSoapClient();

            txtResult.Text = calc.Factorial(x).ToString();
        }
    }
}
