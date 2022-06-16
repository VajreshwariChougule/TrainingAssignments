using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Que_2
{
    public partial class Motorcycles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "Aprilia", "Ducati Panigale", "MV-Agusta" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Pictures/" + str + ".jpg";
        }
        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Aprilia")
            {
                TextBox1.Text = "Rs. 750000";
            }
            else if (DropDownList1.Text == "Ducati Panigale")
            {
                TextBox1.Text = "Rs. 1100000";
            }
            else if (DropDownList1.Text == "MV-Agusta")
            {
                TextBox1.Text = "Rs.900000";
            }
            else
            {
                TextBox1.Text = "Rs.500000";
            }
        }
    }
}