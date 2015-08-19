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
            int out2 = 0;
            int out10 = 0;
            if (intOp == 4)
            {
                out10 = intFirst * intSecond;
                Number = out10;
            }
            else if (intOp == 3)
            {
                out10 = intFirst / intSecond;
                Number = out10;
            }
            else if (intOp == 2)
            {
                out10 = intFirst - intSecond;
                Number = out10;
            }
            else if (intOp == 1)
            {
                out10 = intFirst + intSecond;
                Number = out10;
            }

        }

        protected Int16 BaseTwo(Int16 Number)
        {
            
        }
    }
}