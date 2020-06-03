using System;
using System.Collections.Generic;                   


namespace driversList
{
    public class driver : IEquatable<driver>
    {
        public string fullName { get; set; }  

        public int busNumber { get; set; }                     // Данные позиций в листе
        
        public int routeNumber { get; set; }

        public override string ToString()               // При вызове листа с классом driver в Console.WriteLine() конвертирует все позиции в формат string
        {
            return "Name: " + fullName + "  Autobus number: " + busNumber + "  Route number: " + routeNumber;  
        }

        public bool Equals(driver other)
        {
            if (other == null) return false;
            return (this.busNumber.Equals(other.busNumber));
        }
    }

         class Program
    {
        static void Main(string[] args)
        {
            List<driver> drivers = new List<driver>();
            string b, c, d, q;
            int number, driversCount, driversCount1;


            drivers.Add(new driver() { fullName = "Russell Damian Dominic", busNumber = 15, routeNumber = 20 });
            drivers.Add(new driver() { fullName = "Mills Britton Brandon", busNumber = 25, routeNumber = 99 });        // Заранее добавленные позиции для проверок функций

            for (int i = 1; i > 0; i--)
            {
                // Перечисление всевозможных действий
                Console.WriteLine("\n What action to perform? \n \n  1. General information \n  2. Add new driver \n  3. Remove driver by list number \n  4. Remove driver by list bus number \n  5. Close \n");
                string a = Console.ReadLine();
                bool isNumber = int.TryParse(a, out number);

                if (isNumber && Convert.ToInt32(a) < 6 && Convert.ToInt32(a) > 0)
                {
                    switch (a)
                    {
                        case "1":                                                                 // Полная информация по листу
                            Console.WriteLine("\n General information \n");
                            foreach (driver aDriver in drivers)                                   // Содержание позиций в списке
                            {
                                Console.WriteLine(aDriver);
                            }
                            Console.WriteLine("\n Total number of drivers: " + drivers.Count);   // Количество позиций в списке

                            i++;
                            break;
                        case "2":                                                                // Добавление нового водителя
                                
                                Console.WriteLine("\n Enter in the new driver details");

                                Console.WriteLine(" 1. Enter  full name");
                                b = Console.ReadLine();
                                for (int l = 1; l > 0; l--) 
                                { 
                                    Console.WriteLine(" 2. Enter bus number");
                                    c = Console.ReadLine();

                                    bool isNumC = int.TryParse(c, out number);    // Проверка переменной 
                                    if (isNumC)
                                    {
                                        for (int m = 1; m > 0; m--)
                                        {
                                            Console.WriteLine(" 3. Enter route number");
                                            d = Console.ReadLine();
                                            bool isNumD = int.TryParse(d, out number);
                                            if (isNumD)
                                            {
                                                drivers.Add(new driver()                      // Добавление нового водителя
                                                {
                                                    fullName = b,
                                                    busNumber = Convert.ToInt32(c),
                                                    routeNumber = Convert.ToInt32(d)
                                                });
                                                Console.WriteLine("New number of drivers: " + drivers.Count); 
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n Error: Route number must contain only numbers \n");
                                                Console.ResetColor();
                                                m++;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n Error: Bus number must contain only numbers \n");
                                        Console.ResetColor();
                                        l++;
                                    }
                                }
                            
                            i++;
                            break;
                        case "3":      // Удаление позиции по ее номеру в списке (0, 1, 2, 3...)
                            if (drivers.Count > 0)
                            {
                                for (int n = 1; n > 0; n--)
                                {
                                    Console.WriteLine(" \n Enter the number of the driver to be deleted");
                                    driversCount = drivers.Count;
                                    q = Console.ReadLine();
                                    bool isNum = int.TryParse(q, out number);
                                    if (isNum && Convert.ToInt32(q) < drivers.Count)
                                    {
                                        for (int m = 1; m > 0; m--)
                                        {
                                            Console.WriteLine("\n Are you want delete: " + drivers[Convert.ToInt32(q)] + ", you sure?");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n 1. Yes");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" 2. No");
                                            Console.ResetColor();
                                            c = Console.ReadLine();
                                            if (c == "1" || c == "2")
                                            {
                                                switch (c)
                                                {
                                                    case "1":
                                                        drivers.RemoveAt(Convert.ToInt32(q));  // Удаление позиции
                                                        driversCount1 = drivers.Count;
                                                        if (driversCount1 != driversCount)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("\n Successfully deleted");
                                                            Console.ResetColor();
                                                        }
                                                        else
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("\n Error: The driver with this number was not found");
                                                            Console.ResetColor();
                                                            n++;
                                                        }
                                                        break;
                                                    case "2":
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n Error: Choose the 1 or 2 action");
                                                Console.ResetColor();
                                                m++;
                                            }
                                        }
                                    }
                                    else if (!isNum)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n Error: The driver number must be a number");
                                        Console.ResetColor();
                                        n++;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n Error: No driver with this number");
                                        Console.ResetColor();
                                        n++;
                                    }
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n Error: Drivers not found");
                                Console.ResetColor();
                            }
                            i++;
                            break;
                        case "4":         // Удаление позиции в листе по номеру автобуса
                            if (drivers.Count > 0 && isNumber)
                            {
                                for (int n = 1; n > 0; n--)
                                {
                                    driversCount = drivers.Count;
                                    
                                    Console.WriteLine();
                                    foreach (driver aDriver in drivers)
                                    {
                                        Console.WriteLine(" " + aDriver);
                                    }

                                    Console.WriteLine("\n Enter driver bus number");
                                    
                                    c = Console.ReadLine();
                                    
                                    bool isNum = int.TryParse(c, out number);
                                    if (isNum && drivers.Count > 0)
                                    {
                                        for (int m = 1; m > 0; m--)
                                        {
                                            Console.WriteLine("\n Are you sure you want to remove the driver?");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n 1. Yes");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" 2. No");
                                            Console.ResetColor();
                                            b = Console.ReadLine();
                                            bool isNumB = int.TryParse(c, out number);
                                            if(isNumB && b == "1" || b == "2") {
                                                switch (b)
                                                {
                                                    case "1":
                                                        drivers.Remove(new driver() { busNumber = Convert.ToInt32(c) }); // удаление позиции в листе
                                                        driversCount1 = drivers.Count;
                                                        if (driversCount != driversCount1)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("\n Driver successfully deleted");
                                                            Console.ResetColor();
                                                        }
                                                        else
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("\n Error: Driver with this bus number not found. Try again. \n");
                                                            Console.ResetColor();
                                                            foreach (driver aDriver in drivers)
                                                            {
                                                                Console.WriteLine(aDriver);
                                                            }
                                                            n++;
                                                        }
                                                        break;
                                                    case "2":
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n Error: Choose 1 or 2 action");
                                                Console.ResetColor();
                                                m++;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n Error: Bus number must be a number");
                                        Console.ResetColor();
                                        n++;
                                    }
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n Error: Drivers not found");
                                Console.ResetColor();
                            }
                            i++;
                            break;
                        case "5":   // Закрытие приложения
                            for (int n = 1; n > 0; n--) {   
                                Console.WriteLine("Are you sure? \n 1. Yes \n 2. No");
                            
                            c = Console.ReadLine();
                            bool isNumC5 = int.TryParse(c, out number);
                            
                            
                                if (isNumC5 && c == "1" || c == "2")
                                {
                                    switch (c)
                                    {
                                        case "1":
                                            Console.WriteLine("\n Bye bye! \n ");
                                            Console.ReadLine();
                                            break;
                                        
                                        case "2":
                                            i++;
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n Error: Choose the 1 or 2 action\n");
                                    Console.ResetColor();
                                    n++;
                                }
                            }

                            break;
                    }

                }
                else if(!isNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Error: Enter the action number \n");
                    Console.ResetColor();
                    i++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Error: Select an action from 1 to 5");
                    Console.ResetColor();
                    i++;
                }
                
                
            }
        }
    }
}
