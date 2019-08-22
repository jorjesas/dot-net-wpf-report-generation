﻿using System;
using System.Collections;
using System.ComponentModel;

namespace PoCReports.Models
{
    public class SupplierCollection : ArrayList, ITypedList
    {
        PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            if (listAccessors != null && listAccessors.Length > 0)
            {
                PropertyDescriptor listAccessor = listAccessors[listAccessors.Length - 1];
                if (listAccessor.PropertyType.Equals(typeof(ProductCollection)))
                    return TypeDescriptor.GetProperties(typeof(Product));
                else if (listAccessor.PropertyType.Equals(typeof(OrderDetailCollection)))
                    return TypeDescriptor.GetProperties(typeof(OrderDetail));
            }
            return TypeDescriptor.GetProperties(typeof(Supplier));
        }
        string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
        {
            return "Suppliers";
        }
    }

    public class Supplier
    {
        static int nextID = 0;
        int id;
        string name;
        ProductCollection products = new ProductCollection();

        public ProductCollection Products { get { return products; } }
        public int SupplierID { get { return id; } }
        public string CompanyName { get { return name; } }

        public Supplier(string name)
        {
            this.name = name;

            this.id = nextID;
            nextID++;
        }
        public void Add(Product product)
        {
            products.Add(product);
        }
    }

    public class ProductCollection : ArrayList, ITypedList
    {
        PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            return TypeDescriptor.GetProperties(typeof(Product));
        }

        string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
        {
            return "Products";
        }
    }

    public class Product
    {
        static int nextID = 0;

        OrderDetailCollection orderDetails = new OrderDetailCollection();
        int suppID;
        int prodID;
        string name;

        public int SupplierID { get { return suppID; } }
        public int ProductID { get { return prodID; } }
        public string ProductName { get { return name; } }
        public double Price { get; set; }
        public OrderDetailCollection OrderDetails { get { return orderDetails; } }

        public Product(int suppID, string name)
        {
            this.suppID = suppID;
            this.name = name;
            Price = new Random().NextDouble();

            this.prodID = nextID;
            nextID++;
        }
    }

    public class OrderDetailCollection : ArrayList, ITypedList
    {
        PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            return TypeDescriptor.GetProperties(typeof(OrderDetail));
        }

        string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
        {
            return "OrderDetails";
        }
    }

    public class OrderDetail
    {
        int prodID;
        short quantity;
        public int ProductID { get { return prodID; } }
        public short Quantity { get { return quantity; } }

        public OrderDetail(int prodID, int quantity)
        {
            this.prodID = prodID;
            this.quantity = Convert.ToInt16(quantity);
        }
    }
}
