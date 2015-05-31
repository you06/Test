using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        class book
        {
            int quantity;
            string name;
            double cost;
            public int Quantity
            {
                get { return quantity; }
                set { quantity = (value > 0) ? value : 0; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Cost
            {
                get { return cost; }
                set { cost = (value > 0) ? value : 0; }
            }
            public book(int a, string b, double c)
            {
                quantity = a;
                name = b;
                cost = c;
            }
            public double takeprice()
            {
                return cost;
            }
        }
        class TextBook : book
        {
            public TextBook(int a, string b, double c) : base(a, b, c) { }
            new public double takeprice()
            {
                return 0.8 * base.Cost;
            }
            public void Show()
            {
                Console.WriteLine("书名:{0}\n数量:{1}\n单价:{2}", base.Name, base.Quantity, takeprice());
            }
        }
        class TradeBook : book
        {
            public TradeBook(int a, string b, double c) : base(a, b, c) { }
            new public double takeprice()
            {
                return 0.9 * base.Cost;
            }
            public void Show()
            {
                Console.WriteLine("书名:{0}\n数量:{1}\n单价:{2}", base.Name, base.Quantity, takeprice());
            }
        }
        static void Main(string[] args)
        {
            TextBook t1 = new TextBook(10, "Man", 23.3);
            Console.WriteLine(t1.takeprice());
            t1.Show();
            TradeBook t2 = new TradeBook(20, "Month", 23.3);
            Console.WriteLine(t2.takeprice());
            t2.Show();
        }
    }
}
