using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL1_products_.ProductRepo;

namespace A24sep2018Ado.net
{
    public partial class Modify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductRepository pr1 = new ProductRepository();
            pr1.getDetails();

            Table tb = new Table();
            PlaceHolder1.Controls.Add(tb);
            TableRow tRow = new TableRow();
            tb.Rows.Add(tRow);
            HyperLink hl;
            Label lb1;
            for (int Pl = 0; Pl < pr1.productslist.Count; Pl++)
            {
                TableCell tCell = new TableCell();

                tCell.Attributes.Add("class", "tcell");
                hl = new HyperLink();
                PlaceHolder1.Controls.Add(hl);

                hl.NavigateUrl = "ProductDetails.aspx?Id=" + Pl;
                hl.Text = pr1.productslist[Pl].PName;
               hl.Width = 100;
                lb1 = new Label();
                PlaceHolder1.Controls.Add(lb1);
                lb1.Text = Convert.ToString(pr1.productslist[Pl].Price);
                lb1.Width = 150;
                tRow.Cells.Add(tCell);
                HyperLink h2 = new HyperLink();
                PlaceHolder1.Controls.Add(h2);
                h2.NavigateUrl = "ProductDetails.aspx?Id=" + Pl;
                h2.Text = "PREVIEW";
                h2.Width = 150;
                HyperLink h3 = new HyperLink();
                PlaceHolder1.Controls.Add(h3);
                h3.NavigateUrl = "ProductDetails.aspx?Id=" + Pl;
                h3.Text = "UPDATE";
                h3.Width = 150;
                HyperLink h4 = new HyperLink();
                PlaceHolder1.Controls.Add(h4);
                h4.NavigateUrl = "ProductDetails.aspx?Id=" + Pl;
                h4.Text = "DELETE";
                h4.Width = 450;
                //Console.WriteLine(Environment.NewLine);

            }
        }
    }
}