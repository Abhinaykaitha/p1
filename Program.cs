using System;

namespace w01
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int total = 0;
            double tax=7.25;
            string name = "";
            var order = "";
            int selection = 0;
            var c = "y";
            while(name==""){
                Console.WriteLine($"Enter your name:");
                name=Console.ReadLine();
            }
            Console.WriteLine($"Hello {name} !");
            while(c!="n")
            {
             Console.WriteLine("\n Select the  items from the menu");
            Console.WriteLine("\n 1.Burgers \n 2.Chicken & More \n 3.Beverages");
            var v=Console.ReadLine();
            selection=Convert.ToInt32(v);
           
                switch (selection)
                {
                    case 1: 
                        Console.WriteLine("Choose the required burger");
                        Console.WriteLine("\n 1.Big King XL: $4 2.Bacon King Jr: $3 3.Hamburger: $2");
                        var b1 = Console.ReadLine();
                        var a1 = Convert.ToInt32(b1);
                        Console.WriteLine($"Enter quantity : ");
                        var v1 = Console.ReadLine();
                        count = Convert.ToInt32(v1);
                       
                        switch (a1)
                        {
                            case 1: 
                                    total = total + 4 * count;
                                    order = order + $"\nBig King XL x {count}";
                                    break;
                            case 2: 
                                    total = total + 3 * count;
                                    order = order + $"\nBacon King Jr x {count}";
                                    break;
                            case 3: 
                                    total = total + 2 * count;
                                    order =order + $"\nHamburger x {count}";
                                    break;
                            default:
                            Console.WriteLine("Enter valid input");
                            break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nEnter your choice");
                        Console.WriteLine("\n 1.Crispy Chicken: $3 2.Chicken Tenders: $9 3.Chicken Nuggets: $6  ");
                        var b2=Console.ReadLine();
                        var o2=Convert.ToInt32(b2);
                        Console.WriteLine($"Enter quantity: ");
                        var t1 = Console.ReadLine();
                        count = Convert.ToInt32(t1);
                    switch(o2)
                    {
                        case 1: 
                                    total = total + 3 * count;
                                    order = order + $"\nCrispy Chicken x {count}";
                                    break;
                            case 2: 
                                    total = total + 9 * count;
                                    order = order + $"\nChicken Tenders x {count}";
                                    break;
                            case 3: 
                                    total = total + 6 * count;
                                    order =order + $"\nChicken Nuggets x {count}";
                                    break;
                            default:
                            Console.WriteLine("Enter valid input");
                            break;
                         
                }
                break;
                case 3:
                        Console.WriteLine("Enter your choice");
                        Console.WriteLine("\n 1.Coke: $2 2.Diet Coke: $2 3.Coffee: $4  ");
                        var b3=Console.ReadLine();
                        var o3=Convert.ToInt32(b3);
                        Console.WriteLine($"Enter quantity of: ");
                           var t2 = Console.ReadLine();
                        count = Convert.ToInt32(t2);
                    switch(o3)
                    {
                        case 1: 
                                    total = total + 2 * count;
                                    order = order + $"\nCoke x {count}";
                                    break;
                            case 2: 
                                    total = total + 2 * count;
                                    order = order + $"Diet Coke x {count}";
                                    break;
                            case 3: 
                                    total = total + 4 * count;
                                    order =order + $"Coffee x {count}";
                                    break;
                            default:
                            Console.WriteLine("Enter valid input");
                            break;
                         
            }
            break;
            default: Console.WriteLine("Enter valid input");
            break;
            
        }
    double totalCost(double num){
        return total + total / tax;
    }
    Console.WriteLine($"\nYour order is: \n{order}");
    Console.WriteLine($"\nYour order total is: {total}");
    Console.WriteLine($"\nYour final amount after taxes:{totalCost(total)}");
     Console.WriteLine("\nDo you want to order more? y or n: ");
     c = Console.ReadLine();
}
    
        }
}
}
