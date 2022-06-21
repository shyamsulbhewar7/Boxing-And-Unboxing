using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerEncapApp.Model
{
    public class Customer
    {
        private int _id;
        private string _name;
        private int _orderCount = 0;       
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public int OrderCount()
        {
            return _orderCount;
        }
        public void PlaceOrder()
        {
            _orderCount++;
        }
    }
}
