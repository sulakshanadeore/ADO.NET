using System.Text.Json.Serialization;

namespace EntityLib
{
    public class Products
    {
        public int Prodid { get; set; }
        public string Prodname { get; set; }
        public float Price { get; set; }
        public bool IsAvailable { get; set; }
        public double Qty { get; set; }


    }


    public class ProductOperations {


        static List<Products> prodList=new List<Products>();
        public void SetDataForProduct(Tuple<int, string, float, bool, double> pdata)
        {

            prodList.Add(new Products { Prodid=pdata.Item1, Prodname=pdata.Item2, Price=pdata.Item3,IsAvailable=pdata.Item4,Qty=pdata.Item5});  
        }

        public List<Products> ShowAllProductData() 
        {
            return prodList;


        }


        public Tuple<int, string, float, bool, double> FindProduct(int prodid)
        {
            Products p = prodList.Find(p1 => p1.Prodid == prodid);
           Tuple <int,string,float,bool,double> foundProduct= Tuple.Create<int, string, float, bool, double>(p.Prodid,p.Prodname,p.Price,p.IsAvailable,p.Qty);
            return foundProduct;

        }




    }
}
