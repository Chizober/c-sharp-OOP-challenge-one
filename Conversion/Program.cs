using System;
namespace Conversion{
  class ConversionClass{
        string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
public  string  NumberToWords(int num)
{
    if (num == 0)
        return "zero";

    if (num < 0)
        return "minus " + NumberToWords(Math.Abs(num));

    string words = "";

if ((num / 1000000000) > 0)
    {
        words += NumberToWords(num / 1000000000) + " billion ";
        num %= 1000000000;
    }
    if ((num / 1000000) > 0)
    {
        words += NumberToWords(num / 1000000) + " million ";
        num %= 1000000;
    }

    if ((num / 1000) > 0)
    {
        words += NumberToWords(num / 1000) + " thousand ";
        num %= 1000;
    }

    if ((num / 100) > 0)
    {
        words += NumberToWords(num / 100) + " hundred ";
        num %= 100;
    }

    if (num > 0)
    {
        if (words != "")
            words += "and ";



        if (num < 20)
            words += units[num];
        else
        {
            words += tens[num / 10];
            if ((num % 10) > 0)
                words += "-" + units[num % 10];
        }
    }

    return words;
}
  }
class Program{
   static void Main(string[] args){
  int num;
  Console.WriteLine("Enter a num, to convert");
  num =  Convert.ToInt32(Console.ReadLine());
      ConversionClass toWords = new ConversionClass();
     string answer = toWords.NumberToWords(num) ;
    Console.WriteLine(answer);


  }
}
}
