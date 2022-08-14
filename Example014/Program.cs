using FunctionsOfArray;
using System.Linq;

FunctionsOfArrayClass ar = new FunctionsOfArrayClass();



void Task1()
{
    string caption = "Intensive C# Demo text";
    int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
    int screenHeightPosition = Console.WindowHeight / 2;

    DrawText(caption, screenWidthPosition, screenHeightPosition);

    DrawText(
        text: caption,
        left: screenWidthPosition,
        top: screenHeightPosition
    );

    void DrawText(string text, int left, int top)
    {
        Console.Clear();
        Console.SetCursorPosition(left, top);
        Console.WriteLine(text);
    }
}



void Task2()
{
    ar.Solve(
        a: 1,
        b: -26,
        c: 120);

    Console.WriteLine();

    ar.Solve(
        a: 2,
        b: 1,
        c: -3);

    Console.WriteLine();

    ar.Solve(
        a: 1,
        b: 1,
        c: -6);

}



void Task3()
{
    // В случайных точках консоли вывести случайные числа

    Random r = new Random();

    Console.CursorVisible = false;
    Console.ForegroundColor = ConsoleColor.White;
    ar.cls();
    while (true)
    {
        Console.SetCursorPosition(
            left: r.Next(Console.WindowWidth),
            top: r.Next(Console.WindowHeight)
        );
        Console.Write(r.Next(10));
        Thread.Sleep(1000);
    }
}



void Task4()
{
    ar.cls();
    string text = "(1,2) (2,3) (4,5) (9,7)"
                        .Replace("(", "")
                        .Replace(")", "")
                        ;
    Console.WriteLine(text);
    var data = text.Split(" ")
                    .Select(item => item.Split(','))
                    .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                    .Where(e => e.x % 2 == 0)
                    .Select(point => (point.x * 10, point.y + 10))
                    .ToArray();

    for (int i = 0; i < data.Length; i++)
    {
        Console.WriteLine(data[i]);
    }



}





//Task1();
//Task2();
//Task3();
Task4();