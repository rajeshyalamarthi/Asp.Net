using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL1_products_.ProductRepo;

namespace A24sep2018Ado.net
{
    public partial class ManagerEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductRepository pr1 = new ProductRepository();
            pr1.getDetails();

            Table tb = new Table();
            tb.CssClass = "tcell";

            tb.Attributes.Add("class", "tcell");
            PlaceHolder1.Controls.Add(tb);
            TableRow tRow = new TableRow();
            tRow.CssClass = "tcell";
            tRow.Attributes.Add("class", "tcell");
            tb.Rows.Add(tRow);
            HyperLink hl;
            Label lb1;


            //HyperLink h5 = new HyperLink();
            //PlaceHolder1.Controls.Add(h5);
            //h5.NavigateUrl = "Update.aspx?Id=" + Pl;
            //h5.Text = "INSERT";
            //h5.Width = 250;


            for (int Pl = 0; Pl < pr1.productslist.Count; Pl++)
            {
                TableCell tCell = new TableCell();
                tCell.CssClass = "tcell";
                tCell.Attributes.Add("class", "tcell");
                hl = new HyperLink();
                PlaceHolder1.Controls.Add(hl);

                hl.NavigateUrl = "ProductDetails.aspx?Id=" + Pl;
                hl.Text = pr1.productslist[Pl].PName;
                hl.Width = 100;
                lb1 = new Label();
                PlaceHolder1.Controls.Add(lb1);
                lb1.Text = Convert.ToString(pr1.productslist[Pl].Price);
                lb1.Width = 250;
                tRow.Cells.Add(tCell);
                HyperLink h2 = new HyperLink();
                PlaceHolder1.Controls.Add(h2);
                h2.NavigateUrl = "ProductDetails.aspx?Id=" + Pl;
                h2.Text = "PREVIEW";
                h2.Width = 250;

                HyperLink h3 = new HyperLink();
                PlaceHolder1.Controls.Add(h3);
                h3.NavigateUrl = "ProductDetails.aspx?Id=" + Pl;
                h3.Text = "UPDATE";
                h3.Width = 250;
                HyperLink h4 = new HyperLink();
                PlaceHolder1.Controls.Add(h4);
                h4.NavigateUrl = "ProductDetails.aspx?Id=" + Pl;
                h4.Text = "DELETE";
                h4.Width = 300;
                //Console.WriteLine(Environment.NewLine);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
        }
    }
    }
