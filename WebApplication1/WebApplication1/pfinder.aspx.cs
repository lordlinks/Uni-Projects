using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            time.Text = "The current time is: " + DateTime.Now.ToString("h:mm:ss tt");
            string suburbs = File.ReadAllText("C:\\Users\\links\\Documents\\uni-git\\WebApplication1\\Postcodes.txt");
            string[] lists = suburbs.Split('\n');
            foreach(string pair in lists)
            {
                string[] single = pair.Split(',');
                string first = single[0];
                string last = single[1];
                DropDownList1.Items.Add(new ListItem(first, last));
            }
        }
    }
}