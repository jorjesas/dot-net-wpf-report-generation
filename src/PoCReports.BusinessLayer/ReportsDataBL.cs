using PoCReports.Models;
using System;

namespace PoCReports.BusinessLayer
{
    public class ReportsDataBL
    {
        public static SupplierCollection GetSupplierData()
        {
            SupplierCollection suppliers = new SupplierCollection();

            Supplier supplier = new Supplier("Supplier#1");
            suppliers.Add(supplier);
            supplier.Add(CreateProduct(supplier.SupplierID, "Product#1"));
            supplier.Add(CreateProduct(supplier.SupplierID, "Product#2"));
            supplier.Add(CreateProduct(supplier.SupplierID, "Product#3"));

            supplier = new Supplier("Supplier#2");
            suppliers.Add(supplier);
            supplier.Add(CreateProduct(supplier.SupplierID, "Product@1"));
            supplier.Add(CreateProduct(supplier.SupplierID, "Product@2"));

            supplier = new Supplier("Supplier#3");
            suppliers.Add(supplier);
            supplier.Add(CreateProduct(supplier.SupplierID, "Product:1"));
            supplier.Add(CreateProduct(supplier.SupplierID, "Product:2"));
            supplier.Add(CreateProduct(supplier.SupplierID, "Product:3"));

            return suppliers;
        }

        static Random random = new Random(5);

        private static Product CreateProduct(int supplierID, string productName)
        {
            Product product = new Product(supplierID, productName);

            product.OrderDetails.AddRange(new OrderDetail[] {
                new OrderDetail(product.ProductID, random.Next(0, 100)),
                new OrderDetail(product.ProductID, random.Next(0, 100)),
                new OrderDetail(product.ProductID, random.Next(0, 100)) });

            return product;
        }
    }
}
