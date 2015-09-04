using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac2
{
    public partial class Zodiac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void zod1(object sender, EventArgs e)
        {
            string zodcheck = user1.Value;
            zodcheck = zodcheck.ToLower();
            if (zodcheck == "aries")
            {
                updater("03/21 - 04/20");
            }
            else if (zodcheck == "taurus")
            {
                updater("04/21 - 05/21");
            }
            else if (zodcheck == "gemini")
            {
                updater("05/22 - 06/21");
            }
            else if (zodcheck == "cancer")
            {
                updater("06/22 - 07/22");
            }
            else if (zodcheck == "leo")
            {
                updater("07/23 - 08/22");
            }
            else if (zodcheck == "virgo")
            {
                updater("08/23 - 09/23");
            }
            else if (zodcheck == "libra")
            {
                updater("09/24 - 10/23");
            }
            else if (zodcheck == "scorpio")
            {
                updater("10/24 - 11/22");
            }
            else if (zodcheck == "sagittarius")
            {
                updater("11/23 - 12/21");
            }
            else if (zodcheck == "capricorn")
            {
                updater("12/22 - 01/20");
            }
            else if (zodcheck == "aquarius")
            {
                updater("01/21 - 02/19");
            }
            else if (zodcheck == "pisces")
            {
                updater("02/20 - 03/20");
            }
            else
            {
                updater("Not found");
            }
        }

        protected void updater(string inthis)
        {
            out1.Value = inthis;
        }

        protected void zod2(object sender, EventArgs e)
        {
            int maino = 0;
            string months = user2.Value;
            string days = user3.Value;
            try
            {
                maino += Convert.ToInt16(months);
            }
        }
    }
}