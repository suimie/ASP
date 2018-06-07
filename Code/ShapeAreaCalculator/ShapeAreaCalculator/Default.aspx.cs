using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShapeAreaCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedValue)
            {
                case "Square":
                    /*
                    UserControl squareCtrl =
                        (UserControl)LoadControl("UserControls/Square.ascx.cs");
                    PlaceHolder1.Controls.Add(squareCtrl);
                    */
                    UserControl squareCtrl =
                        (UserControl)LoadControl("UserControls/test.ascx.cs");
                    PlaceHolder1.Controls.Add(squareCtrl);
                    break;
                case "Rectangle":
                    break;
                case "Triangle":
                    break;
                case "Circle":
                    break;
                case "Ellipse":
                    break;
                case "Trapezoid":
                    break;
                default:
                    break;
            }

        }
    }
}