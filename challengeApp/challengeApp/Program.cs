var number = 1234567890;
string numberAsString = number.ToString();
char[] numbers = numberAsString.ToArray();

var counter0 = 0;
var counter1 = 0;
var counter2 = 0;
var counter3 = 0;
var counter4 = 0;
var counter5 = 0;
var counter6 = 0;
var counter7 = 0;
var counter8 = 0;
var counter9 = 0;

foreach (char digit in numbers)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1')
    {
        counter1++;
    }
    else if (digit == '2')
    {
        counter2++;
    }
    else if (digit == '3')
    {
        counter3++;
    }
    else if (digit == '4')
    {
        counter4++;
    }
    else if (digit == '5')
    {
        counter5++;
    }
    else if (digit == '6')
    {
        counter6++;
    }
    else if (digit == '7')
    {
        counter7++;
    }
    else if (digit == '8')
    {
        counter8++;
    }
    else if (digit == '9')
    {
        counter9++;
    }
}
Console.WriteLine("Liczba " + number + " składa się z:");
Console.WriteLine("0-" + counter0);
Console.WriteLine("1-" + counter1);
Console.WriteLine("2-" + counter2);
Console.WriteLine("3-" + counter3);
Console.WriteLine("4-" + counter4);
Console.WriteLine("5-" + counter5);
Console.WriteLine("6-" + counter6);
Console.WriteLine("7-" + counter7);
Console.WriteLine("8-" + counter8);
Console.WriteLine("9-" + counter9);
