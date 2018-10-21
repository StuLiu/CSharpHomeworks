using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLINQ
{
    class Person
    {
        public uint ID { get; set; }
        public Person(uint id) { ID = id; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person(1));
            list.Add(new Person(4));
            list.Add(new Person(2));
            list.Add(new Person(3));
            var a = list.Where(s => s.ID > 1).OrderByDescending(s => s.ID);
            a.ToList().ForEach(s => { Console.WriteLine(s.ID); });
        }
    }
}
