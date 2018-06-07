using ShapeAreaCalculator.UserControls;
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
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            LoadControl();
        }

        
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        


        private void LoadControl()
        {
            switch (DropDownList1.SelectedValue)
            {
                case "Square":
                    Square squareCtrl =
                        (Square)Page.LoadControl("~/UserControls/Square.ascx");
                    PlaceHolder1.Controls.Add(squareCtrl);
                    break;
                case "Rectangle":
                    Rectangle rectangleCtrl =
                        (Rectangle)Page.LoadControl("~/UserControls/Rectangle.ascx");
                    PlaceHolder1.Controls.Add(rectangleCtrl);
                    break;
                case "Triangle":
                    Triangle triangelCtrl =
                        (Triangle)Page.LoadControl("~/UserControls/Triangle.ascx");
                    PlaceHolder1.Controls.Add(triangelCtrl);
                    break;
                case "Circle":
                    Circle circleCtrl =
                        (Circle)Page.LoadControl("~/UserControls/Circle.ascx");
                    PlaceHolder1.Controls.Add(circleCtrl);
                    break;
                /*
                case "Ellipse":
                    Ellipse ellipseCtrl =
                       (Ellipse)Page.LoadControl("~/UserControls/Ellipse.ascx");
                    PlaceHolder1.Controls.Add(ellipseCtrl);
                    break;
                case "Trapezoid":
                    Trapezoid trapezoidCtrl =
                        (Trapezoid)Page.LoadControl("~/UserControls/Trapezoid.ascx");
                    PlaceHolder1.Controls.Add(trapezoidCtrl);
                    break;
                    */
                default:
                    break;
            }
        }

    }
}