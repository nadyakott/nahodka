using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InputOutputMessages;

namespace Nahodka
{
    public partial class ShowAllmessages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageRepeater.DataSource = InputOutputMessage.listObj;
            MessageRepeater.DataBind();
        }
    }
}