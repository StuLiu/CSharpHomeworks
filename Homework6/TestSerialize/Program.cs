using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace TestSerialize
{
    public class Bag {
        public int Size { get; set; }
        public Bag() { }
        public Bag(int size) { Size = size; }
        public override string ToString() { return $"bagSize={Size}"; }
    }

    public class Hat {
        public int Size { get; set; }
        public Hat() { }
        public Hat(int size) { Size = size; }
        public override string ToString() { return $"HatSize={Size}"; }
    }

    public class People {
        private List<Bag> bags;
        public int Age { get; set; }
        public string Name { get; set; }
        public Hat Hat { get; set; }
        public List<Bag> Bags { get { return bags; } }
        public People() { bags = new List<Bag>(); }
        public People(Hat hat, int age = 20, string name="myname") { 
            Age = age; 
            Name = name;
            Hat = hat;
            bags = new List<Bag>();
        }
        public void addBag(int a) { bags.Add(new Bag(a)); }
        public override string ToString() { return $"{Name}:{Age},{bags[0]},{bags[1]},{Hat}"; }
    }

    class Program {
        static void Main(string[] args) {
            Hat hat = new Hat(10);
            People p1 = new People(hat, 23, "liuwang");
            p1.addBag(155); p1.addBag(156);
            People p2 = new People(hat, 24, "liss");
            p2.addBag(255); p2.addBag(256);
            List<People> plist = new List<People>();
            plist.Add(p1);
            plist.Add(p2);
            //BinaryFormatter bf = new BinaryFormatter();

            XmlSerializer xs = new XmlSerializer(typeof(List<People>));
            using (FileStream fs = new FileStream("people.xml", FileMode.Create)) {
                xs.Serialize(fs, plist);
            }
            using (FileStream fs = new FileStream("people.xml", FileMode.Open)) {
                List<People> pl = (List<People>)xs.Deserialize(fs);
                pl.ForEach(p => Console.WriteLine(p.ToString()));
            }
        }
    }
}
