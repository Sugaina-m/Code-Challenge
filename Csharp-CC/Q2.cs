using System;

class MainClass {
  public static void Main (string[] args) {
    int disprice,day1,day2,day3,day1tot,day2tot,day3tot;
    Console.WriteLine("Enter the name of product");
    string product = Console.ReadLine();
    Console.WriteLine("Enter the price of product:");
    int price = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("is the product on sale? (y/n) ");
    char sale = Console.ReadLine()[0];
    switch (sale){
        case 'y':
                  Console.WriteLine("Enter the product sold in day 1");
                  day1 = Convert.ToInt32(Console.ReadLine());
                  disprice = price - (price * 7 / 100);
                  day1tot = disprice * day1;
                  Console.WriteLine("Enter the product sold in day 2");
                  day2 = Convert.ToInt32(Console.ReadLine());
                  disprice = disprice - (price * 7 / 100);
                  day2tot = disprice * day2;
                  Console.WriteLine("Enter the product sold in day 3");
                  day3 = Convert.ToInt32(Console.ReadLine());
                  disprice = disprice - (price * 7 / 100);
                  day3tot = disprice * day3;
                  Console.WriteLine(product);
                  Console.WriteLine("day 1 sales total  " + day1tot);
                  Console.WriteLine("day 1 sales total  " + day2tot);
                  Console.WriteLine("day 1 sales total  " + day3tot);
                  break;
        case 'n':
                  Console.WriteLine("Enter the product sold in day 1");
                  day1 = Convert.ToInt32(Console.ReadLine());
                  day1tot = price * day1;
                  Console.WriteLine("Enter the product sold in day 2");
                  day2 = Convert.ToInt32(Console.ReadLine());
                  day2tot = price * day2;
                  Console.WriteLine("Enter the product sold in day 3");
                  day3 = Convert.ToInt32(Console.ReadLine());
                  day3tot = price * day3;
                  Console.WriteLine(product);
                  Console.WriteLine("day 1 sales total  " + day1tot);
                  Console.WriteLine("day 1 sales total  " + day2tot);
                  Console.WriteLine("day 1 sales total  " + day3tot);
                  break;
        default :Console.WriteLine("enter y or n");
                 break;   
                 
    
    }
  }
}
