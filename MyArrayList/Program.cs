using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            list.Add("Elma");
            list.Add("Armut");
            list.Add("Muz");
            list.Add("Kiraz");

            Console.WriteLine("Liste: " + list.ToString());

            list.Insert(2, "Portakal");
            Console.WriteLine("2. index'e Portakal eklendi: " + list.ToString());

            list.RemoveAt(1);
            Console.WriteLine("1. index silindi: " + list.ToString());

            Console.WriteLine("Index 2: " + list.Get(2));
            Console.WriteLine("Toplam Eleman: " + list.Count());
        }
    }
}
