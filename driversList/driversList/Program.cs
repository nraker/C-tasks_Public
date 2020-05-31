using System;
using System.Collections.Generic;


namespace driversList
{
    public class driver : IEquatable<driver>
    {
        public string fullName { get; set; }

        public int busNumber { get; set; }
        
        public int routeNumber { get; set; }

        public override string ToString()
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
            drivers.Add(new driver() { fullName = "Mills Britton Brandon", busNumber = 20, routeNumber = 99 });

            for (int i = 0; i >= 0; i--)
            {
                Console.WriteLine("\n What action to perform? \n \n  1. General information \n  2. Add new driver \n  
                                  3. Remove driver by list number \n  4. Remove driver by list bus number \n  5. Close \n");
                string a = Console.ReadLine();
                bool isNumber = int.TryParse(a, out number);

                if (isNumber && Convert.ToInt32(a) < 6 && Convert.ToInt32(a) > 0)
                {
                    switch (a)
                    {
                        case "1":
                            Console.WriteLine("\n General information \n");
                            foreach (driver aDriver in drivers)
                            {
                                Console.WriteLine(aDriver);
                            }
                            Console.WriteLine("\n Total number of drivers: " + drivers.Count);

                            i++;
                            break;
                        case "2":
                            

                                Console.WriteLine("\n Enter in the new driver details");

                                Console.WriteLine(" 1. Enter  full name");
                                b = Console.ReadLine();
                                for (int l = 0; l >= 0; l--) 
                                { 
                                    Console.WriteLine(" 2. Enter bus number");
                                    c = Console.ReadLine();

                                    bool isNumC = int.TryParse(c, out number);
                                    if (isNumC)
                                    {
                                        for (int m = 0; m >= 0; m--)
                                        {
                                            Console.WriteLine(" 3. Enter route number");
                                            d = Console.ReadLine();
                                            bool isNumD = int.TryParse(d, out number);
                                            if (isNumD)
                                            {
                                                drivers.Add(new driver()
                                                {
                                                    fullName = b,
                                                    busNumber = Convert.ToInt32(c),
                                                    routeNumber = Convert.ToInt32(d)
                                                });
                                                Console.WriteLine("New number of drivers: " + drivers.Count);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Route number must contain only numbers \n");
                                                m++;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bus number must contain only numbers \n");
                                        l++;
                                    }
                                }
                            
                            i++;
                            break;
                        case "3":
                            if (drivers.Count > 0)
                            {
                                for (int n = 0; n >= 0; n--)
                                {
                                    Console.WriteLine(" \n Enter the number of the driver to be deleted");
                                    driversCount = drivers.Count;
                                    q = Console.ReadLine();
                                    bool isNum = int.TryParse(q, out number);
                                    if (isNum && Convert.ToInt32(q) < drivers.Count)
                                    {
                                        drivers.RemoveAt(Convert.ToInt32(q));
                                        driversCount1 = drivers.Count;
                                        if (driversCount1 != driversCount)
                                        {
                                            Console.WriteLine("Successfully deleted");
                                        }
                                        else
                                        {
                                            Console.WriteLine("The driver with this number was not found");
                                            n++;
                                        }
                                    }
                                    else if (!isNum)
                                    {
                                        Console.WriteLine("The driver number must be a number");
                                        n++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No driver with this number");
                                        n++;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Drivers not found");
                            }
                            i++;
                            break;
                        case "4":
                            if (drivers.Count > 0 && isNumber)
                            {
                                for (int n = 0; n >= 0; n--)
                                {
                                    driversCount = drivers.Count;

                                    Console.WriteLine("Enter driver bus number");
                                    c = Console.ReadLine();
                                    bool isNum = int.TryParse(c, out number);
                                    if (isNum && drivers.Count > 0)
                                    {
                                        drivers.Remove(new driver() { busNumber = Convert.ToInt32(c) });
                                        driversCount1 = drivers.Count;
                                        if (driversCount != driversCount1)
                                        {
                                            Console.WriteLine("Driver successfully deleted");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Driver with this bus number not found. Try again. \n");
                                            foreach (driver aDriver in drivers)
                                            {
                                                Console.WriteLine(aDriver);
                                            }
                                            n++;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bus number must be a number");
                                        n++;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Drivers not found");
                            }
                            i++;
                            break;
                        case "5":
                            break;
                    }

                }
                else if(!isNumber)
                {
                    Console.WriteLine("Enter the action number \n");
                    i++;
                }
                else
                {
                    Console.WriteLine("\n Select an action from 1 to 5");
                    i++;
                }
                
                
            }
        }
    }
}
