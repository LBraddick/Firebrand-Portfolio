using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaculatorWebApplication
{
    public partial class CaculatorWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCaculate_Click(object sender, EventArgs e)
        {
            int x, y;

            caculatorServiceReference.CaculatorWebServiceSoapClient calc = new caculatorServiceReference.CaculatorWebServiceSoapClient();

            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);

            txtResult.Text = calc.Add(x, y).ToString();
        }
    }
}