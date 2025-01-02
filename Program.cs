using Dz9.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run1();
            Run2();
        }

        static void Run1()
        {
            Console.WriteLine("Упражнение 10.1.");
            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();

            Console.WriteLine("Введите строку для шифрования и дешифрования:");
            string text = Console.ReadLine();

            string aEncoded = aCipher.Encode(text);
            string aDecoded = aCipher.Decode(aEncoded);
            string bEncoded = bCipher.Encode(text);
            string bDecoded = bCipher.Decode(bEncoded);

            Print("ACipher", text, aEncoded, aDecoded);
            Print("BCipher", text, bEncoded, bDecoded);
        }

        static void Print(string cipherName, string original, string encoded, string decoded)
        {
            Console.WriteLine($"\n{cipherName}:");
            Console.WriteLine("Оригинал: " + original);
            Console.WriteLine("Зашифровано: " + encoded);
            Console.WriteLine("Дешифровано: " + decoded);
        }
        static void Run2()
        {
            Console.WriteLine("Домашнее задание 10.1.");
            Circle circle = new Circle("Красный", true, 0, 0, 5);
            Rectangle rectangle = new Rectangle("Синий", true, 10, 10, 4, 6);

            Console.WriteLine("Исходные данные фигур:");
            circle.Print();
            rectangle.Print();

            circle.Move(2, 3);
            rectangle.Move(-1, -2);

            Console.WriteLine("\nПосле перемещения:");
            circle.Print();
            rectangle.Print();
        }
    }
}
