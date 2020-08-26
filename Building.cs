using System;

namespace Planner
{
    // building is a class
    public class Building
    {
        // fields
        private string _designer = "Faith Magras";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        // properties of the building 
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        // this is the constructor
        // the name of the constructor is the same name as the class
        public Building(string address)
        {
            _address = address;
        }
        // public methods  and it dose not return a value
        public void Construct()
        {
            _dateConstructed = DateTime.Now;

        }
        public void Purchase(string buyer)
        {
            _owner = buyer;
        }
    }
}