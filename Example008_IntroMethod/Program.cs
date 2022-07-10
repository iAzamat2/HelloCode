
//Zadacha1();
Zadacha2();

void Zadacha1()
{
    double f(double x)
    {
        double result = x * x + 1;
        return result;
    }

    Console.WriteLine($"x^2 + 1 = {f(4)} ");
}

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

void Zadacha2()
{
    int a1 = 15, b1 = 21, c1 = 39;
    int a2 = 12, b2 = 2311, c2 = 33;
    int a3 = 13, b3 = 23111, c3 = 313;

    //int max1 = Max(a1, b1, c1);
    //int max2 = Max(a2, b2, c2);
    //int max3 = Max(a3, b3, c3);
    //int max = Max(max1, max2, max3);
    int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
    Console.WriteLine(max);
}

