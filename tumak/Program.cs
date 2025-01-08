using System;
using tumak.Classes;
using tumak.Interface;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1() 
        {
            List<ICipher> cipherList = new List<ICipher>()
            {
                new ACipher(),
                new BCipher()
            };
            int count = 0;
            for (int i = 0; i < cipherList.Count; i++)
            {
                ICipher Cipher = cipherList[i];
                string input = Console.ReadLine();
                string encodedA = Cipher.Encode(input);
                string decodedA = Cipher.Decode(encodedA);

                Console.WriteLine(i == 0 ? "класс A" : "класс B");
                Console.WriteLine($"оригинал: {input}");
                Console.WriteLine($"закодированный текст:  {encodedA}");
                Console.WriteLine($"раскодированный:  {decodedA}");
            }
        }
        static void Task2()
        {
            Point point = new Point("Red", true, 5, 10);
            point.Display();
            point.MoveHor(3);
            point.MoveVer(-2);
            point.Display();

            // Создание окружности
            Circle circle = new Circle(5, "Blue", true, 0, 0);
            circle.Display();
            circle.MoveVer(10);
            circle.ChangeColor("Green");
            circle.Display();

            // Создание прямоугольника
            Rectangle rectangle = new Rectangle(4, 5, "Yellow", false, 2, 2);
            rectangle.Display();
            rectangle.ChangeVisibility(true);
            rectangle.MoveHor(5);
            rectangle.Display();
        }
    }
}