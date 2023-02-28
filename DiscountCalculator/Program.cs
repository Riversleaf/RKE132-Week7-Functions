//total < 10 - 1%
//total >= 10 && total < 20 - 5%
//total >= 20 - 10%

Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());
double Discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {Discount}%");

double newTotal = CalculateNewTotal(userInput, Discount);

Console.WriteLine($"Your updated total with discount {Discount}%: {newTotal}.");
static double CalculateDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else 
    { 
        return 10;
    }
}

static double CalculateNewTotal(double total, double Discount)
{
    double result = total - (total * Discount) / 100;
    return result;
}