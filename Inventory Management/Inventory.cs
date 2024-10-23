﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Inventory_Management
{
    public class Inventory:ISerializable
    {
        private Dictionary<int, int> productStock = new Dictionary<int, int>();
        public Inventory(Dictionary<int, int> productStock)
        {
            this.productStock = productStock;
        }
        public Dictionary<int, int> ProductStock { get => productStock; set => productStock = value; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ProductStock", ProductStock, typeof(Dictionary<int, int>));
        }
        public Inventory(SerializationInfo info, StreamingContext context)
        {
            ProductStock = (Dictionary<int, int>)info.GetValue("ProductStock", typeof(Dictionary<int, int>));
        }
        public Inventory()
        {

        }
    }
}
