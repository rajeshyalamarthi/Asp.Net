using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DAL1_products_.ProductRepo;

namespace A24sep2018Ado.net
{
    public partial class ProductManagement : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.IsInRole("Product"))
            {
                //Response.Redirect("Default1.aspx");
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
            
            for (int count = 0; count <repository.productslist.Count;count++)
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
                hyper.NavigateUrl = "ProductDetails.aspx?id="+ count;
                    Label label = new Label();
                    PlaceHolder1.Controls.Add(label);
                    label.Text = Convert.ToString(repository.productslist[count].Price);
             
                



                //row.Cells.Add(cell);


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

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagerEdit.aspx");
        }
    }
            }

        //   // Table table = new Table();
        //    HtmlTableRow row = new HtmlTableRow();
        //    HtmlTableCell cell = new HtmlTableCell();
        //    //ProductRepository PrdRep = new ProductRepository();
        //    ProductRepository p = new ProductRepository();
        //    p.getDetails();
        //    cell.ColSpan = 3;

        //    cell.InnerText = ProductRepository.productslist[1].PName;
        //    row.Cells.Add(cell);
        //    tableContent.Rows.Add(row);

        //    row = new HtmlTableRow();
        //    cell = new HtmlTableCell();

        //  //  cell.InnerText = tableConte
        //    row.Cells.Add(cell);

        //    cell = new HtmlTableCell();
        //    cell.InnerText = "2";
        //    row.Cells.Add(cell);

        //    cell = new HtmlTableCell();
        //    cell.InnerText = "3";
        //    row.Cells.Add(cell);

        //    tableContent.Rows.Add(row);

        //    row = new HtmlTableRow();
        //    cell = new HtmlTableCell();

        //    cell.InnerText = "a";
        //    row.Cells.Add(cell);

        //    cell = new HtmlTableCell();
        //    cell.InnerText = "b";
        //    row.Cells.Add(cell);

        //    cell = new HtmlTableCell();
        //    cell.InnerText = "c";
        //    row.Cells.Add(cell);

        //    tableContent.Rows.Add(row);


        //    row = new HtmlTableRow();
        //    cell = new HtmlTableCell();
        //    cell.InnerText = "m";
        //    row.Cells.Add(cell);

        //    cell = new HtmlTableCell();
        //    cell.InnerText = "n";
        //    row.Cells.Add(cell);

        //    cell = new HtmlTableCell();
        //    cell.InnerText = "o";
        //    row.Cells.Add(cell);

        //    tableContent.Rows.Add(row);

        //    row = new HtmlTableRow();
        //    cell = new HtmlTableCell();

        //    HtmlInputButton input = new HtmlInputButton();
        //    input.ID = "Button1";
        //    input.Value = "button";

        //    cell.ColSpan = 3;
        //    cell.Controls.Add(input);
        //    row.Cells.Add(cell);
        //    tableContent.Rows.Add(row);
        //}

        //    using (SqlConnection connection = new SqlConnection())
        //    {
        //        connection.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";
        //        connection.Open();
        //        string sql = "select * from Products";
        //        SqlCommand sqlCommand = new SqlCommand(sql, connection);
        //        int rowcnt;
        //        int rowctr;
        //        int cellctr;
        //        int cellcnt;
        //        rowcnt = int.Parse(TextBox1.Text);
        //        cellcnt = int.Parse(TextBox2.Text);
        //        for (rowctr = 1; rowctr <= 6; rowctr++)
        //        {
        //            // Create new row and add it to the table.
        //            TableRow tRow = new TableRow();

        //            for (cellctr = 1; cellctr <= cellcnt; cellctr++)
        //            {
        //                // Create a new cell and add it to the row.
        //                TableCell tCell = new TableCell();
        //                tCell.Text = "Row " + rowctr + ", Cell " + cellctr;
        //                tRow.Cells.Add(tCell);


        //                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
        //                {

        //                    sqlDataReader.Read();

        //                    Label1.Text = sqlDataReader["Pname"].ToString();
        //                    Label2.Text = sqlDataReader["price"].ToString();
        //                    Label3.Text = sqlDataReader["ImageUrl"].ToString();
        //                    Image1.ImageUrl = sqlDataReader["ImageUrl"].ToString();


        //                    sqlDataReader.Read();

        //                    Label4.Text = sqlDataReader["Pname"].ToString();
        //                    Label5.Text = sqlDataReader["price"].ToString();
        //                    Label6.Text = sqlDataReader["ImageUrl"].ToString();
        //                    Image2.ImageUrl = sqlDataReader["ImageUrl"].ToString();

        //                }
        //                //  SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //                //DataSet ds = new DataSet();
        //                //GridView1.DataSource = ds;
        //                //GridView1.DataBind();


        //            }
        //        }
        //    }
    
