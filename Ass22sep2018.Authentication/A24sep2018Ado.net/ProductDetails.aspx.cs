﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL1_products_.ProductRepo;

namespace A24sep2018Ado.net
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int  s =  Convert.ToInt32( Request.QueryString["Id"]);

            ProductRepository repo = new ProductRepository();
            repo.getDetails();
            Image image = new Image();
            PlaceHolder1.Controls.Add(image);
            image.ImageUrl = repo.productslist[s].ProductUrl;
            Label la = new Label();
            PlaceHolder1.Controls.Add(la);
            Label1.Text = repo.productslist[s].PName;
            Label2.Text =Convert.ToString(repo.productslist[s].Price);
            Label3.Text = repo.productslist[s].Description;



            //string Q1 = "select *from Productdetails where id=" + s + "";

            //SqlConnection con = new SqlConnection(connStr);
            //con.Open();
            //SqlCommand cmd = new SqlCommand(Q1, con);
            //SqlDataReader myDataReader = cmd.ExecuteReader();

        }
    }
}