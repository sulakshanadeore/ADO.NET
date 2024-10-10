using System.ComponentModel.Design;
using System.Text.Json.Serialization;

namespace EntityLib
{
    public class Products
    {
        public int Prodid { get; set; }

        //40 chars
        string _prodname;
        public string Prodname 
        {
            get 
            {
                return _prodname; 
            } 
            set 
            {
                if (value.Length > 40)
                {
                    // throw new ProductNameTooLongException("Product name cannot be 40 chars");
                    throw new ArgumentException("Name too long");
                }
                else
                {
                    _prodname = value;
                }
            
            }
        }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public double Qty { get; set; }

        public int suppid { get; set; }
        
        public int catid { get; set; }
        //20 chars
        public string QuantityPerUnit { get; set; }
        public int unitsinstock { get; set; }
    }


    public class ProductOperations {


        static List<Products> prodList=new List<Products>();
        public void SetDataForProduct(string prodname, int suppid, int catid, string qtyPerUnit, double unitprice, int unitsinstock)
        {

           // prodList.Add(new Products { Prodid=pdata.Item1, Prodname=pdata.Item2, Price=pdata.Item3,IsAvailable=pdata.Item4,Qty=pdata.Item5});  
           NrothwindDAO.ProductsServiceDAO daoObj=new   NrothwindDAO.ProductsServiceDAO();
            bool status=daoObj.InsertProduct(prodname, suppid,catid,qtyPerUnit,unitprice, unitsinstock);
            if (status)
            {
                Console.WriteLine("Successfully inserted products....");
            }
            else {

                Console.WriteLine("Some error occured.....");
            }

      }

        public List<Products> ShowAllProductData() 
        {
            return prodList;


        }

        public bool Deleteproduct(int prodid) {

            NrothwindDAO.ProductsServiceDAO dao = new NrothwindDAO.ProductsServiceDAO();
            dao.DeleteProduct(prodid);

            return true;

        }

        public  Tuple<int, string, int, int, string, int, int>  FindProduct(int prodid)
        {
            Tuple<int, string, int, int, string, int, int> found = null;
            NrothwindDAO.ProductsServiceDAO dao = new NrothwindDAO.ProductsServiceDAO();
            found=dao.FindProduct(prodid);
            return found;
        }
        //public Tuple<int, string, float, bool, double> FindProduct(int prodid)
        //{
        //    Products p = prodList.Find(p1 => p1.Prodid == prodid);
        //   Tuple <int,string,float,bool,double> foundProduct= Tuple.Create<int, string, float, bool, double>(p.Prodid,p.Prodname,p.Price,p.IsAvailable,p.Qty);
        //    return foundProduct;

        //}

        public bool UpdateProduct(int prodid, string prodname, double unitprice)
        {
            NrothwindDAO.ProductsServiceDAO dao = new NrothwindDAO.ProductsServiceDAO();
           bool status=dao.UpdateProduct(prodid, prodname, unitprice);
            return status;


        }


        }
}
