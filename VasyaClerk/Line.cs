using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaClerk
{
    public class Line
    {
        public static string Tickets(int[] peopleInLine)
        {

            //Your code is here...
            Console.WriteLine(string.Join(",", peopleInLine));
            int till = 0;
            int priceOfTicket = 25;
            int change = 0;
            bool canMakeChange = false;
            string result = string.Empty;
            foreach (int bankNote in peopleInLine)
            {
                //run through the line and see if you can sell a tickect.

                change = bankNote - priceOfTicket;
                Console.WriteLine("Banknote: " + bankNote + " Till:" + till + " Change: " + change);

                till = till - change;

                if (till >= 0)
                {
                    canMakeChange = true;
                }
                else
                {
                    canMakeChange = false;
                    break;
                }
                if (bankNote == 25 | bankNote == 50)
                {
                    till = till + priceOfTicket;
                }

            }

            if (peopleInLine.Count() > 0)
            {
                if (canMakeChange)
                {
                    result = "YES";
                }
                else
                {
                    result = "NO";
                }
            }

            Console.WriteLine(result);
            return result;
        }

//        public static string Tickets3(int[] peopleInLine)
//        {

//            //Your code is here...
//            int[] deposit = new int[] { 0, 0, 0 };

//            Console.WriteLine(string.Join(",", peopleInLine));
//            foreach (int p in peopleInLine)
//            {
//                if (p == 25)
//                {
//                    deposit = new[] { deposit[0] + 1, deposit[1], deposit[2] };
//                }
//                else if (p == 50)
//                {
//                    deposit = new[] { deposit[0] - 1, deposit[1], deposit[2] };
//                }
//                else
//                {
//                    if (deposit[0] >= 1 & deposit[1] >= 1)
//                    {
//                        deposit = new[] { deposit[0] - 1, deposit[1] - 1, deposit[2] };
//                    }
//                    else if (deposit[1] == 0 & deposit[0] >= 3)
//                    {
//                        deposit = new[] { deposit[0] - 3, deposit[1], deposit[2] };
//                    }
//                    else
//                    {
//                        deposit = new[] { deposit[0] - 3, deposit[1], deposit[2] };
//                    }
//                }
//                Console.WriteLine(string.Join(",", deposit));

//            }
//            if (deposit[0] < 0 | deposit[1] < 0 | deposit[2] < 0)
//            {
//                Console.WriteLine("NO");
//                return "NO";
//            }
//            else
//            {
//                Console.WriteLine("NO");
//                return "YES";
//            }

////        }
//    }
    }
}
