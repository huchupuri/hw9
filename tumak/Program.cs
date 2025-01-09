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
//        Упражнение 10.1. Создать интерфейс ICipher, который определяет методы поддержки
//шифрования строк.В интерфейсе объявляются два метода encode() и decode(), которые
//используются для шифрования и дешифрования строк, соответственно.Создать класс
//ACipher, реализующий интерфейс ICipher.Класс шифрует строку посредством сдвига
//каждого символа на одну «алфавитную» позицию выше. Например, в результате такого
//сдвига буква А становится буквой Б.Создать класс BCipher, реализующий интерфейс
//ICipher.Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й
//позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца
//алфавита.Например, буква В заменяется на букву Э. Написать программу,
//демонстрирующую функционирование классов.
        static void Task1() 
        {
            Console.WriteLine("Задание 1");
            List<ICipher> cipherList = new List<ICipher>()
            {
                new ACipher(),
                new BCipher()
            };
            Console.WriteLine("ввеидте строку: ");
            string input = Console.ReadLine();

            for (int i = 0; i < cipherList.Count; i++)
            {
                ICipher Cipher = cipherList[i];
                string encodedA = Cipher.Encode(input);
                string decodedA = Cipher.Decode(encodedA);

                Console.WriteLine(i == 0 ? "класс A" : "класс B");
                Console.WriteLine($"оригинал: {input}");
                Console.WriteLine($"закодированный текст:  {encodedA}");
                Console.WriteLine($"раскодированный:  {decodedA}");
            }
        }

//        Домашнее задание 10.1. Создать класс Figure для работы с геометрическими фигурами.В
//качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». Реализовать
//операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение
//цвета, опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить
//состояние всех полей объекта.Создать класс Point (точка) как потомок геометрической
//фигуры.Создать класс Circle (окружность) как потомок точки. В класс Circle добавить
//метод, который вычисляет площадь окружности. Создать класс Rectangle (прямоугольник)
//как потомок точки, реализовать метод вычисления площади прямоугольника.Точка,
//окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и
//вертикали, изменения цвета. Подумать, какие методы можно объявить в интерфейсе, нужно
//ли объявлять абстрактный класс, какие методы и поля будут в абстрактном классе, какие
//методы будут виртуальными, какие перегруженными.
        static void Task2()
        {
            Console.WriteLine("Задание 2");
            Point point = new Point("Red", true, 5, 10);
            point.Display();
            point.MoveHor(3);
            point.MoveVer(-2);
            point.Display();

            Circle circle = new Circle(5, "Blue", true, 0, 0);
            circle.Display();
            circle.MoveVer(10);
            circle.ChangeColor("Green");
            circle.Display();

            Rectangle rectangle = new Rectangle(4, 5, "Yellow", false, 2, 2);
            rectangle.Display();
            rectangle.ChangeVisibility(true);
            rectangle.MoveHor(5);
            rectangle.Display();
        }
    }
}