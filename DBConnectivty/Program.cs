
using EntityLib;

using System.Collections.Concurrent;
using System.ComponentModel;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter choice 1. Insert 2. Delete 3.Update 4.Find 5.Exit");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                InsertProduct();
                break;
                case 2:
                ProductOperations po=new ProductOperations();
                bool status=po.Deleteproduct(83);
                if (true)
                {
                    Console.WriteLine(status);
                }
                else
                {

                    Console.WriteLine(status);
                }
                

                break;

            case 3:
                po=new  ProductOperations();
                bool ans=po.UpdateProduct(80, "Lunch", 100);
                Console.WriteLine(ans);
                break;
            case 4:
                po=new ProductOperations();
                Tuple<int, string, int, int, string, int, int>  productFound= po.FindProduct(80);
                Console.WriteLine(productFound.Item1);
                Console.WriteLine(productFound.Item2);
                Console.WriteLine(productFound.Item3);
                Console.WriteLine(productFound.Item4);
                Console.WriteLine(productFound.Item5);
                Console.WriteLine(productFound.Item6);
                Console.WriteLine(productFound.Item7);


                break;
            default:
                break;
        }
        



        //        Employee employee = new Employee();


        //var ProductData = new Tuple<int, string, float>(101, "Tea", 10.30f);//Row
        //Console.WriteLine($"Product data : ProductID={ProductData.Item1} , ProductNAme={ProductData.Item2}, Product Price={ProductData.Item3}");


        //Tuple<int,string> data=Tuple.Create<int, string>(1, "A");
        //Console.WriteLine(data.Item1);
        //Console.WriteLine(data.Item2);


        //WorkingWithTuples();
        // EmployeeOperations eo=new EmployeeOperations();
        // Employee employee=new Employee();

        //employee.Empname = "Anand";
        // employee.City = "Mumbai";
        // int empid=eo.AddNewEmployee(employee);
        // Console.WriteLine($"{employee.Empname}'s  employeeid = {empid}");


        //Employee employee2 = new Employee();
        //employee2.Empname = "Suresh";
        //employee2.City = "Mumbai";
        // empid = eo.AddNewEmployee(employee2);
        //Console.WriteLine($"{employee2.Empname}'s  employeeid = {empid}");



        //Employee employee3 = new Employee();
        //employee3.Empname = "Mahesh";
        //employee3.City = "Mumbai";
        // empid = eo.AddNewEmployee(employee);
        //Console.WriteLine($"{employee3.Empname}'s  employeeid = {empid}");

        //Console.WriteLine("=====================");
        //List<Employee> emplist=eo.AllEmplist();

        //foreach (var item in emplist)
        //{
        //    Console.WriteLine(item.Empid);
        //    Console.WriteLine(item.Empname);
        //    Console.WriteLine(item.City);
        //}

















        Console.Read();
    }

    private static void InsertProduct()
    {
        Products p = new Products();
        p.Prodname = "Another Product";
        p.suppid = 1;
        p.catid = 1;
        p.Price = 19;
        p.unitsinstock = 11;
        p.IsAvailable = true;
        p.QuantityPerUnit = "Dozen";
        ProductOperations po = new ProductOperations();
        po.SetDataForProduct(p.Prodname, p.suppid, p.catid, p.QuantityPerUnit, p.Price, p.unitsinstock);
    }

    //private static void WorkingWithTuples()
    //{
    //    ProductOperations po = new ProductOperations();

    //    po.SetDataForProduct(new Tuple<int, string, float, bool, double>(1, "Coffee", 12, true, 1110));
    //    po.SetDataForProduct(new Tuple<int, string, float, bool, double>(2, "tea", 11, true, 1110));
    //    po.SetDataForProduct(new Tuple<int, string, float, bool, double>(3, "lime", 13, false, 10));
    //    po.SetDataForProduct(new Tuple<int, string, float, bool, double>(4, "water", 14, true, 3310));
    //    po.SetDataForProduct(new Tuple<int, string, float, bool, double>(5, "Lime water", 14, false, 11));

    //    List<Products> productList = po.ShowAllProductData();
    //    foreach (var item in productList)
    //    {
    //        Console.WriteLine(item.Prodid);
    //        Console.WriteLine(item.Prodname);
    //        Console.WriteLine(item.Price);
    //        Console.WriteLine(item.IsAvailable);
    //        Console.WriteLine(item.Qty);
    //    }
    //    Console.WriteLine("====================================");
    //    Console.WriteLine("Enter the product id to find");
    //    int id = Convert.ToInt32(Console.ReadLine());
    //    Tuple<int, string, float, bool, double> data = po.FindProduct(id);
    //    Console.WriteLine(data.Item1);
    //    Console.WriteLine(data.Item2);
    //    Console.WriteLine(data.Item3);
    //    Console.WriteLine(data.Item4);
    //    Console.WriteLine(data.Item5);
    //}
}