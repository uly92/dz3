// задание 1

/*
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int pal = 0, num = number;
while (number > 0) 
{
    pal = pal * 10 + number % 10; number /= 10;
}
Console.WriteLine(num == pal ? "is palindrom" : "is not palindrom");
*/

//задание  2
/*
void Squares(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write(Math.Pow(counter, 2));
        if(counter != number) Console.Write(", ");
        else Console.Write(".");
        counter++;
    }
}

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The series of squares of numbers:");
Squares(num);
*/

// задание 2

/*
double Distance(double xA, double yA,double zA, double xB, double yB,double zB)
{
    double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return Math.Round(length, 2);
}
Console.Write("Input an x-coordonate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordonate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an z-coordonate of point A: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an x-coordonate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordonate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an z-coordonate of point B: ");
double zB = Convert.ToDouble(Console.ReadLine());
double distanceBetweenAB = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance between points A and B is {distanceBetweenAB}.");
*/

// задача 3

/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
void Squares(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write(Math.Pow(counter, 3));
        if(counter != number) Console.Write(", ");
        else Console.Write(".");
        counter++;
    }
}


Console.WriteLine("The series of squares of numbers:");
Squares(num);
*/
