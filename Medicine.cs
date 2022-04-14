using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Medicine
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted;
        public Medicine(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
            _id++;
            Id = _id;
        }
        public void Sell()
        {
            Count--;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {_id} Name: {Name} Price: {Price} Count: {Count} Is deleted: {IsDeleted}");
        }
    }
}
