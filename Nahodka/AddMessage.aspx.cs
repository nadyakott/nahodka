using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InputOutputMessages;

namespace Nahodka
{
    public partial class AddMessage : System.Web.UI.Page
    {
        public static string headerFoundItem { get; set; } = "";
        public static string headerLostItem { get; set; } = "";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            txtbx_adress.Text = string.Empty;
            txtbx_type.Text = string.Empty;
            txtbx_name.Text = string.Empty;
            txtbx_descript.Text = string.Empty;
            txtbx_date.Text = string.Empty;
            txtbx_color.Text = string.Empty;
            txtbx_breed.Text = string.Empty;
            txtbx_size.Text = string.Empty;
            
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            headerLostItem = "Message Lost Item";
            InputOutputMessage.Input = new List<string>();
            InputOutputMessage.Input.Add(txtbx_adress.Text);
            InputOutputMessage.Input.Add(txtbx_type.Text);
            InputOutputMessage.Input.Add(txtbx_breed.Text);
            InputOutputMessage.Input.Add(txtbx_color.Text);
            InputOutputMessage.Input.Add(txtbx_date.Text);
            InputOutputMessage.Input.Add(txtbx_size.Text);
            InputOutputMessage.Input.Add(txtbx_descript.Text);
            InputOutputMessage.Input.Add(txtbx_name.Text);

            var message = new InputOutputMessage()
            {
                messageType = MessageType.Lost,
                Name = txtbx_name.Text,
                Color = txtbx_color.Text,
                Adress = txtbx_adress.Text,
                Type = txtbx_type.Text,
                Size = txtbx_size.Text,
                Breed = txtbx_breed.Text,
                Description = txtbx_descript.Text
            };
            InputOutputMessage.AddMessage(message);
            //Session["IsStudentAdded"] = true;
            //Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            headerFoundItem = "Message Found Item";
            InputOutputMessage.Output = new List<string>();
            InputOutputMessage.Output.Add(txtbx_fadress.Text);
            InputOutputMessage.Output.Add(txtbx_ftype.Text);
            InputOutputMessage.Output.Add(txtbx_fbreed.Text);
            InputOutputMessage.Output.Add(txtbx_fcolor.Text);
            InputOutputMessage.Output.Add(txtbx_fdate.Text);
            InputOutputMessage.Output.Add(txtbx_fsize.Text);
            InputOutputMessage.Output.Add(txtbx_fdescr.Text);
            InputOutputMessage.Output.Add(txtbx_fname.Text);

            var message = new InputOutputMessage()
            {
                messageType = MessageType.Found,
                Name = txtbx_fname.Text,
                Color = txtbx_fcolor.Text,
                Adress = txtbx_fadress.Text,
                Type = txtbx_ftype.Text,
                Size = txtbx_fsize.Text,
                Breed = txtbx_fbreed.Text,
                Description = txtbx_fdescr.Text
            };
            InputOutputMessage.AddMessage(message);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtbx_fadress.Text = string.Empty;
            txtbx_ftype.Text = string.Empty;
            txtbx_fname.Text = string.Empty;
            txtbx_fdescr.Text = string.Empty;
            txtbx_fdate.Text = string.Empty;
            txtbx_fcolor.Text = string.Empty;
            txtbx_fbreed.Text = string.Empty;
            txtbx_fsize.Text = string.Empty;
        }
    }
}