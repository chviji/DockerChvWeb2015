using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DockerChvWeb2015
{
    public partial class classicpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClickMe_Click(object sender, EventArgs e)
        {
            lblTxtReturn.Text = String.Format("Message return from Code behind. [{0}]" , System.DateTime.Now.ToString("ddd dd MMM yyyy - hh:mm:ss tt zzz"));
        }
    }
}