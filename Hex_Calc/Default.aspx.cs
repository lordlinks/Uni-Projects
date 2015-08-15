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
        protected void Page_Load(object sender, EventArgs e)
        {
            public string Number = "11001100";
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
            if(intOp == 4)
            {
                out10 = intFirst * intSecond;
                
            }                        
        }

        protected void BaseTwo(Number)
        {
            
        }
    }
}