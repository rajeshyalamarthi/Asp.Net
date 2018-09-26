using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL1_products_.ProductRepo;

namespace A24sep2018Ado.net
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.IsInRole("User"))
            {

                Response.Redirect("Default.aspx");


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ID = "1";
            PlaceHolder1.Controls.Add(table);
            ProductRepository repository = new ProductRepository();
            repository.getDetails();
            //int count1 = 0;

            for (int count = 0; count < repository.productslist.Count; count++)
            {
                TableRow row = new TableRow();
                table.Rows.Add(row);
                //for (int cellcount = 0; cellcount < 2; cellcount++)
                //{
                TableCell cell = new TableCell();
                row.Cells.Add(cell);
                HyperLink hyper = new HyperLink();
                Image image = new Image();

                PlaceHolder1.Controls.Add(image);
                image.ImageUrl = repository.productslist[count].ProductUrl;
                PlaceHolder1.Controls.Add(hyper);
                hyper.Text = repository.productslist[count].PName;
                hyper.NavigateUrl = "ProductDetails.aspx?id=" + count;
                Label label = new Label();
                PlaceHolder1.Controls.Add(label);
                label.Text = Convert.ToString(repository.productslist[count].Price);




            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Table table1 = new Table();
            table1.ID = "1";
            PlaceHolder2.Controls.Add(table1);
            ProductRepository repository1 = new ProductRepository();
            repository1.Searchbyname(TextBox1.Text);
            for (int count = 0; count < repository1.nameslist.Count; count++)
            {

                TableRow row = new TableRow();
                table1.Rows.Add(row);
                TableCell cell = new TableCell();
                row.Cells.Add(cell);
                HyperLink hyper = new HyperLink();
                Image image = new Image();


                //PlaceHolder2.Controls.Add(image);
                PlaceHolder2.Controls.Add(image);
                image.ImageUrl = repository1.nameslist[count].ProductUrl;
                PlaceHolder2.Controls.Add(hyper);
                hyper.Text = repository1.nameslist[count].PName;
                hyper.NavigateUrl = "ProductDetails.aspx?id=" + repository1.nameslist.Count;
                Label label = new Label();
                PlaceHolder2.Controls.Add(label);
                label.Text = Convert.ToString(repository1.nameslist[count].Price);
            }

        }


    }
}