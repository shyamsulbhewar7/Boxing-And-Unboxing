using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPropertiesApp.Model
{
    public class Student
    {
        private int _roll;
        private string _name;
        private float _totalFee = 100000, _remainingFee = 100000;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public float RemainingFee
        {
            get { return _remainingFee; }
        }
        public float TotalFee
        {
            get { return _totalFee; }
        }
        public int Roll
        {
            set { 
                if(value > 0)
                {
                    _roll = value;
                }
                else
                {
                    Console.WriteLine("Invalid ID .");
                }
            }
            get { return _roll; }
        }
        public void PayFees(int amt)
        {
            if(_remainingFee == 0)
            {
                Console.WriteLine("Fee are already paid ");
            }
            else if(_remainingFee >= amt)
            {
                _remainingFee -= amt;
            }
            else
            {
                _remainingFee = 0;
            }
        }
    }
}
