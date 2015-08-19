using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hex_Calc
{
    public partial class _Default : Page
    {
        public int Number = 1;
        public string out10 = "a";
        public string out2 = "b";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void calcbtn(object sender, EventArgs e)
        {
            string First = in1.Value;
            string Second = in2.Value;
            string Operator = OP.SelectedValue;
            int intFirst = Convert.ToInt16(First);
            int intSecond = Convert.ToInt16(Second);
            int intOp = Convert.ToInt16(Operator);
            if (intOp == 4)
            {
                Number = intFirst * intSecond;
            }
            else if (intOp == 3)
            {
                Number = intFirst / intSecond;
            }
            else if (intOp == 2)
            {
                Number = intFirst - intSecond;
            }
            else if (intOp == 1)
            {
                Number = intFirst + intSecond;
            }
            baseTen();
            baseTwo();
        }

        protected void baseTen()
        {
            string strOut = Number.ToString();
            out10 = strOut;
            base10.Value = out10;
        }

        protected void baseTwo()
        {
            out2 = Convert.ToString(Number, 2);
            base2.Value = out2;
        }

        protected void countbtn(object sender, EventArgs e)
        {
            string test = base2.Value;
            int c0 = test.Split('0').Length - 1;
            int c1 = test.Split('1').Length - 1;
            count0.Value = c0.ToString();
            count1.Value = c1.ToString();
        }
    }
}