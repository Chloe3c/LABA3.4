double startX = -5;
double endX = 10;
double step = 0.2;

for (double x = startX; x <= endX; x += step)
{
    double y;

    if (x > 12.5)
    {
        y = Math.Pow(x, 2) + 2.5;
    }
    else if (x >= 0 && x <= 12.5)
    {
        y = Math.Exp(x - Math.Sin(x)) + Math.Cos(0.001 * x);
    }
    else 
    {
        y = 1 - Math.Pow(x, 2);
    }

    Console.WriteLine($"x: {x:F1}, y: {y:F4}");
}
