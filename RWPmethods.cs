/**       
 *--------------------------------------------------------------------
 * 	   File name:               {program.cs}
 * 	Project name:               {Homework6}
 *--------------------------------------------------------------------
 * Author’s name and email:	    {Ryan Peters}				
 *          Course-Section:     {CSCI 1250-001}
 *           Creation Date:	    {10/25/22}		
 * -------------------------------------------------------------------
 */


static void ShowCharacter(string phrase, int position)
{
    char character = phrase[position-1];
    Console.WriteLine(character);
}

ShowCharacter("New York", 3);


static void CalculateRetail(double wholesaleCost, double markupPercentage)
{
    double retailCost = wholesaleCost + (wholesaleCost * (markupPercentage / 100));
    Console.WriteLine($"The item's retail price is ${wholesaleCost + (wholesaleCost * (markupPercentage / 100))}.");
}

CalculateRetail(12, 50);


static double Celsius (double degreesFahrenheit)
{
    double degreesCelsius;
    degreesCelsius = ((5 / 9) * (degreesFahrenheit - 32));
    return degreesCelsius;
}

Console.WriteLine(Celsius(50));
//Doesn't work but I could not figure out why.


// used post on https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number by user Soner Gönül for IsPrime method

static bool IsPrime (int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

Console.WriteLine(IsPrime(102));