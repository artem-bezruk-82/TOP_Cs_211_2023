using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace material_03_task3
{
    public struct Article
    {
        public int Code { get; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public static int Count { get; private set; }

        static Article() { Count = 0; }

        public Article(string name, double? price)
        {
            Code = ++Count;
            Name = name;
            Price = price;
        }

        public Article(string name) : this(name, null) { }
        public override string ToString()
        {
            return $"code: {Code}\tname: {Name}\tprice: {Price}";
        }
    }
}
