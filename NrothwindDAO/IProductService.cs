using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrothwindDAO
{
    internal interface IProductService
    {
        public bool InsertProduct(string prodname, int suppid, int catid, string qtyPerUnit, double unitprice, int unitsinstock);
        public void DeleteProduct(int prodid);
        public bool UpdateProduct(int prodid, string prodname, double unitprice);
        public Tuple<int, string, int, int, string, int, int> FindProduct(int prodid);


    }
}
