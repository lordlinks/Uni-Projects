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
                int m1= Convert.ToInt16(months)*100;
                int m2= Convert.ToInt16(days);
                if (m1 >= 100 && m1 <= 1200)
                {
                    maino += m1;
                    if (m2 >= 1 && m2 <= 31)
                    {
                        maino += m2;
                        checker(maino);
                    }
                    else
                    {
                        up2("Bad Input");
                    }
                }
                else
                {
                    up2("Bad Input");
                }
            }
            catch (System.FormatException)
            {
                up2("Bad Input");
            }
        }

        protected void checker(int num)
        {
            int maino = num;
            if (maino < 122)
            {
                up2("Aquarius");
            }
            else if (maino < 221)
            {
                up2("Pisces");
            }
            else if (maino < 322)
            {
                up2("Aries");
            }
            else if (maino < 422)
            {
                up2("Taurus");
            }
            else if (maino < 523)
            {
                up2("Gemini");
            }
            else if (maino < 623)
            {
                up2("Cancer");
            }
            else if (maino < 724)
            {
                up2("Leo");
            }
            else if (maino < 824)
            {
                up2("Virgo");
            }
            else if (maino < 925)
            {
                up2("Libra");
            }
            else if (maino < 1025)
            {
                up2("Scorpio");
            }
            else if (maino < 1124)
            {
                up2("Sagittarius");
            }
            else if (maino < 1223)
            {
                up2("Capricorn");
            }
            else
            {
                up2("ERROR");
            }
        }

        protected void up2(string inthat)
        {
            out2.Value = inthat;
        }
    }
}