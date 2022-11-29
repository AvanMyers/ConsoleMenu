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
            const string CommandSetNickname = "nick";
            const string CommandChangeFont = "font";
            const string CommandSetPassword = "pass";
            const string CommandShowInfo = "info";
            const string CommandExit = "exit";
            bool isWork = true;
            bool isBlocked = false;
            string nickname = "";
            string password = "";
            string enteredPassword;

            Console.WriteLine("Здравствуйте. Здесь вы можете ввести информацию и корректировать её.");
            Console.WriteLine($" 1. Установить никнейм - {CommandSetNickname} \n" +
                $" 2. Изменить цвет шрифта на синий - {CommandChangeFont}. \n" +
                $" 3. Установить пароль - {CommandSetPassword}. \n" +
                $" 4. Вывести имя после установки пароля - {CommandShowInfo}. \n" +
                $" 5. Выход - {CommandExit}");


            while (isWork)
            {
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case CommandSetNickname:
                            Console.WriteLine("Введите ваше Никнейм");
                            nickname = Console.ReadLine();
                        break;

                    case CommandChangeFont:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;

                    case CommandSetPassword:
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

                    case CommandShowInfo:
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

                    case CommandExit:
                        Console.WriteLine("До свидание!");
                        isWork = false;
                        break;
                }
            }
        }
    }
}
