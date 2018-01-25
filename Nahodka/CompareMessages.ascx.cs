using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InputOutputMessages;

namespace Nahodka
{
    public partial class CompareMessages1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_compare_Click(object sender, EventArgs e)
        {
            lbl_comparePerc.Text=InputOutputMessage.CompareTwoArrays(InputOutputMessage.Input, InputOutputMessage.Output).ToString()+"%";
            
        }
    }
}