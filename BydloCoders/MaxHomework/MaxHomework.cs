using System;
using System.Linq;

namespace Citrus {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Строка:");
            var s = Console.ReadLine();


            Console.WriteLine("Удалить всё кроме букв:");
            var newS = "";
            foreach (var c in s) if (char.IsLetter(c)) newS += c;
            Console.WriteLine(newS + "\n");
            s = newS;


            Console.WriteLine("Перевернуть строку:");
            newS = "";
            var chars = s.Reverse();
            foreach (var c in chars) newS += c;
            Console.WriteLine(newS + "\n");
            s = newS;


            Console.WriteLine("Сортировать строку:");
            newS = "";
            var list = s.ToList();
            list.Sort();
            foreach (var c in list) newS += c;
            Console.WriteLine(newS + "\n");

            Console.ReadLine();
        }
    }
}
