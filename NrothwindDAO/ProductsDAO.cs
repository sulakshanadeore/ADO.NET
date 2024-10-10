using Microsoft.Data.SqlClient;
using System;

namespace NrothwindDAO
{
    public class ProductsServiceDAO:IProductService
    {


        //public SqlConnection Connect()
        //{
        //    //NorthwindUtil.DBPropertyUtil.FileName = "appsettings.json";


        //    //NorthwindUtil.DBPropertyUtil.GetConnectionString();
        //    //string cn=NorthwindUtil.DBPropertyUtil.ConnectionString;
        //    string cnstring = "Data Source=.\\sqlexpress;Initial Catalog=northwind;Integrated Security=True;Trust Server Certificate=True";
        //    SqlConnection cn=new SqlConnection(cnstring);
        //    return cn;
        //}


        public void DeleteProduct(int prodid)
        {
            // throw new NotImplementedException();
            SqlConnection cn = NorthwindUtil.DBPropertyUtil.GetConnectionString();

            SqlCommand cmd = new SqlCommand("Delete from Products where productID=" + prodid,cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public Tuple<int, string, int, int, string, int, int> FindProduct(int prodid)
        {
            SqlConnection cn = NorthwindUtil.DBPropertyUtil.GetConnectionString();

            Tuple<int, string, int, int, string, int, int> productTuple=null;
            SqlCommand cmd = new SqlCommand("select * from Products where productID=" + prodid, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {

                dr.Read();
                int productid = Convert.ToInt32(dr[0]);
                string productname = dr[1].ToString();
                int supplierid = Convert.ToInt32(dr[2]);
                int categoryid = Convert.ToInt32(dr[3]);
                string QtyPerUnit = dr[4].ToString();
                int unitprice = Convert.ToInt32(dr[5]);
                int unitsinstock = Convert.ToInt32(dr[6]);
                cn.Close();
                 productTuple =
                    Tuple.Create<int, string, int, int, string, int, int>(productid, productname, supplierid, categoryid, QtyPerUnit, unitprice, unitsinstock);




            }
            return productTuple;
        }

        public bool InsertProduct( string prodname, int suppid, int catid, string qtyPerUnit, double unitprice, int unitsinstock)
        {
            try
            {

                SqlConnection cn = NorthwindUtil.DBPropertyUtil.GetConnectionString();



                SqlCommand cmd = new SqlCommand("[dbo].InsertProduct", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", prodname);
                cmd.Parameters.AddWithValue("@SupplierID", suppid);
                cmd.Parameters.AddWithValue("@CategoryID", catid);
                cmd.Parameters.AddWithValue("@QuantityPerUnit", qtyPerUnit);
                cmd.Parameters.AddWithValue("@UnitPrice", unitprice);
                cmd.Parameters.AddWithValue("@UnitsInStock", unitsinstock);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;   

        }

        public bool UpdateProduct(int prodid, string prodname,double unitprice)
        {

            SqlConnection cn=NorthwindUtil.DBPropertyUtil.GetConnectionString();
            SqlCommand cmd = new SqlCommand("[dbo].UpdateProduct", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prodid", prodid);
            cmd.Parameters.AddWithValue("@productname", prodname);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);

           

                 cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            return true;
            
        }
    }
}
