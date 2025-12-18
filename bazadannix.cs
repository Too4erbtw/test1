using System;
using System.Collections.Generic;
using System.Linq;
namespace Too4er
{
    class bazadannix
    {
        static void AddUser(List<string> names, List<string> lastnames, List<string> passwords)
        {
            Console.Clear();
            Console.WriteLine("Введите имя, фамилию и пароль через пробел");
            string[] input = Console.ReadLine().Split(' ');
            if (names != null && lastnames != null && passwords != null)
            {
                names.Add(input[0].ToLower());
                lastnames.Add(input[1].ToLower());
                passwords.Add(input[2]);
            }
            Console.WriteLine("Теперь список пользователей выглядит так:");
            for(int i = 0; i<names.Count(); i++)
            {
                Console.WriteLine($"{i+1}. {names[i]} {lastnames[i]} {passwords[i]}");
            }
        }
        static void DelUser(List<string> names, List<string> lastnames, List<string> passwords)
        {
            Console.Clear();
            Console.WriteLine("Введите только имя пользователя, которого хотите удалить");
            for (int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} {lastnames[i]} {passwords[i]}");
            }
            string input = Console.ReadLine().ToLower();
            if (names != null && lastnames != null && passwords != null)
            {
                if (names.Contains(input))
                {
                    int index = names.IndexOf(input);
                    names.RemoveAt(index);
                    lastnames.RemoveAt(index);
                    passwords.RemoveAt(index);
                    Console.WriteLine("Теперь список пользователей выглядит так:");
                    for (int i = 0; i < names.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {names[i]} {lastnames[i]} {passwords[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Такого пользователя нет");
                }
            }
        }
        static void ChangeName(List<string> names, List<string> lastnames, List<string> passwords)
        {
            Console.Clear();
            if (names != null && lastnames != null && passwords != null)
            {
                Console.WriteLine("Введите индекс пользователя, чье имя хотите изменить");
                for (int i = 0; i < names.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {names[i]} {lastnames[i]} {passwords[i]}");
                }
                int index = int.Parse(Console.ReadLine());
                if (index <= names.Count())
                {
                    Console.WriteLine("Введите новое имя:");
                    names[index-1] = Console.ReadLine().ToLower();
                    Console.Clear();
                    Console.WriteLine("Теперь список пользователей выглядит так:");
                    for (int i = 0; i < names.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {names[i]} {lastnames[i]} {passwords[i]}");
                    }
                }
            }
        }
        static void ChangeLastName(List<string> names, List<string> lastnames, List<string> passwords)
        {
            Console.Clear();
            if (names != null && lastnames != null && passwords != null)
            {
                Console.WriteLine("Введите индекс пользователя, чью фамилию хотите изменить");
                for (int i = 0; i < names.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {names[i]} {lastnames[i]} {passwords[i]}");
                }
                int index = int.Parse(Console.ReadLine());
                if (index <= names.Count())
                {
                    Console.WriteLine("Введите новую фамилию:");
                    lastnames[index-1] = Console.ReadLine().ToLower();
                    Console.Clear();
                    Console.WriteLine("Теперь список пользователей выглядит так:");
                    for (int i = 0; i < names.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {names[i]} {lastnames[i]} {passwords[i]}");
                    }
                }
            }
        }
        static void ChangePassword(List<string> names, List<string> lastnames, List<string> passwords)
        {
            Console.Clear();
            if (names != null && lastnames != null && passwords != null)
            {
                Console.WriteLine("Введите индекс пользователя, чей пароль хотите изменить");
                for (int i = 0; i < names.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {names[i]} {lastnames[i]} {passwords[i]}");
                }
                int index = int.Parse(Console.ReadLine());
                if (index <= names.Count())
                {
                    Console.WriteLine("Введите новый пароль:");
                    passwords[index - 1] = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Теперь список пользователей выглядит так:");
                    for (int i = 0; i < names.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {names[i]} {lastnames[i]} {passwords[i]}");
                    }
                }
            }
        }
        void Main()
        {
            List<string> Names = new List<string>(); 
            List<string> LastNames = new List<string>();
            List<string> passwords = new List<string>();
            bool isWorking = true;
            
            while (isWorking)
            {
                Console.WriteLine("Что вы хотите сделать");
                Console.WriteLine("a - добавить пользователя, d - удалить пользователя, cn - Сменить имя, cl - сменить фамилию, cp - сменить пароль, q - выход");
                string action = Console.ReadLine().ToLower();
                switch(action)
                {
                    case "q":
                        isWorking = false; break;
                    case "a":
                        AddUser(Names, LastNames, passwords); break;
                    case "d":
                        DelUser(Names, LastNames, passwords); break;
                    case "cn":
                        ChangeName(Names, LastNames, passwords); break;
                    case "cl":
                        ChangeLastName(Names, LastNames, passwords); break;
                    case "cp":
                        ChangePassword(Names, LastNames, passwords); break;
                    default:
                        Console.WriteLine("Такого дейстивия нет!"); break;
                }
            }
        }
    }
}