using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if(!e.Day.IsOtherMonth && e.Day.Date.Day %2 == 0)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ForeColor = System.Drawing.Color.White;
                e.Cell.Text = "x";
                e.Cell.ToolTip = "Booked";
            }
            else
            {
                e.Cell.ToolTip = "Available";
            }
        }
    }
}