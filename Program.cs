using System;
class Program{


//Method 1: Show Character
  static void main(String[] args)
  {
      showChar("New York", 2);
 }
    
    static void showChar(String aString, int i)
    {
        System.Console.WriteLine((i));
    }


//Method 2: retail Price
static double CalculateRetail(double wholesalePrice, double markupPercentage)
{
    double retailPrice = wholesalePrice + wholesalePrice * markupPercentage/100;
    return retailPrice;
}
 static void Main(string[]args)
{
Console.WriteLine("What is the wholesale cost of the item?");
double wholesaleCostInput = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the markup percentage of the item?");
double markupPercentageInput = Convert.ToDouble(Console.ReadLine());

double rPrice = CalculateRetail(wholesaleCostInput, markupPercentageInput);

Console.WriteLine("Item's retail price: " + rPrice.ToString("0.00"));
}

//Method 3: Temperature Table
float celsius(float F)
{
return (5*(F-32))/9;
}

int temp() 
{
   
   System.Console.WriteLine("Converting into celsius\n");
   for(int i=0;i<=100 && i>80;i++)
   {
   System.Console.WriteLine("%d : %fC\n",i,celsius(i));
   }
  
   return 0;

  System.Console.WriteLine($"{temp}");
}
}
//Method 4: Prime 

 




