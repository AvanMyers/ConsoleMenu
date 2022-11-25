using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            bool isBlocked = false;
            bool isNicknameAvailible = false;
            string nickname = "";
            string password = "";
            string enteredPassword;

            Console.WriteLine("Здравствуйте. Здесь вы можете ввести информацию и корректировать её.");
            Console.WriteLine(" 1. Установить никнейм \n 2. Изменить цвет шрифта на синий. \n 3. Установить пароль. \n 4. Вывести имя после установки пароля. \n 5. Выход");

            while (isWork)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        if (isBlocked == true)
                        {
                            Console.WriteLine("Введите пароль: ");
                            enteredPassword = Console.ReadLine();
                            if (enteredPassword == password && isNicknameAvailible)
                            {
                                Console.WriteLine($"Здравствуйте {nickname} \n"); 
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введите ваше Никнейм");
                            nickname = Console.ReadLine();
                            isNicknameAvailible = true;
                        }
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;

                    case "3":
                        if (isBlocked == true)
                        {
                            Console.WriteLine("Введите пароль: ");
                            enteredPassword = Console.ReadLine();
                            if (enteredPassword == password)
                            {
                                Console.WriteLine($"Здравствуйте {nickname} \n" +
                                    $"Введите новый пароль: ");
                                password = Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Придумайте новый пароль: ");
                            password = Console.ReadLine();
                            isBlocked = true;
                        }
                        break;

                    case "4":
                        if (isBlocked == true)
                        {
                            Console.WriteLine("Введите пароль: ");
                            enteredPassword = Console.ReadLine();
                            if (enteredPassword == password)
                            {
                                Console.WriteLine($"Здравствуйте {nickname} \n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Сперва установите пароль.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("До свидание!");
                        isWork = false;
                        break;
                }
            }

        }
    }
}
