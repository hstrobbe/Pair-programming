using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currBal = 5000;
            decimal bitcoin=0, etherium=0, litecoin=0;
            decimal bitcoinWorth = 7480, etheriumWorth = (decimal)586.15, litecoinWorth = (decimal)119.04;
            bool flag = true;

            Console.WriteLine($"Your Current balance is: {currBal}");

            do
            {
                Console.WriteLine("\nChoose a Action: \n1)Purchase digital currency. \n2)Sell for cash \n3)View all accounts \n4)Transfer currency. ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Select a currency to purchase: B)Bitcoin     E)Etherium      L)Litecoin");
                        switch (Console.ReadLine())
                        {
                            case "b":
                            case "B":
                                Console.WriteLine($"You can purchase up to: {currBal/bitcoinWorth} Bitcoins");
                                Console.WriteLine("How many are you buying?:");
                                decimal userin = decimal.Parse(Console.ReadLine());
                                if (userin > currBal / bitcoinWorth)
                                {
                                    Console.WriteLine($"Sorry u a broke b****");
                                }
                                else
                                {
                                    Console.WriteLine($"You have purchased {userin} bitcoin(s)");
                                    bitcoin += userin;
                                    currBal -= userin * bitcoinWorth;

                                }

                                break;
                            case "e":
                            case "E":
                                Console.WriteLine($"You can purchase up to: {currBal / etheriumWorth} Etherium");
                                Console.WriteLine("How many are you buying?:");
                                 userin = decimal.Parse(Console.ReadLine());
                                if (userin > currBal / etheriumWorth)
                                {
                                    Console.WriteLine($"Sorry u a broke b****");
                                }
                                else
                                {
                                    Console.WriteLine($"You have purchased {userin} Etherium(s)");
                                    etherium += userin;
                                    currBal -= userin * etheriumWorth;

                                }

                                break;
                            case "l":
                            case "L":
                                Console.WriteLine($"You can purchase up to: {currBal / litecoinWorth} Litecoin");
                                Console.WriteLine("How many are you buying?:");
                                userin = decimal.Parse(Console.ReadLine());
                                if (userin > currBal / litecoinWorth)
                                {
                                    Console.WriteLine($"Sorry u a broke b****");
                                }
                                else
                                {
                                    Console.WriteLine($"You have purchased {userin} Litecoin(s)");
                                    litecoin += userin;
                                    currBal -= userin * litecoinWorth;

                                }

                                break;
                            default:
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Sell currency for cash");

                        break;

                    case "3":
                        Console.WriteLine("View balances");
                        Console.WriteLine($"Cash: {currBal:c}");
                        Console.WriteLine($"Bitcoin: {bitcoin:c}");
                        Console.WriteLine($"Etherium: {etherium:c}");
                        Console.WriteLine($"Litecoin: {litecoin:c}");
                        break;

                    case "4":
                        Console.WriteLine("Transfer Between Currency types");
                        break;

                    default:
                        flag = false;
                        break;
                }

            } while (flag);
        }
    }
}
