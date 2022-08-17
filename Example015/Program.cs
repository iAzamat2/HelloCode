/*
Собрать строку с числами от a до b, a ≤ b

*/

void Task1()
{
    string NumbersFor(int a, int b)
    {
        string result = String.Empty;
        for (int i = a; i <= b; i++)
        {
            result += $"{i} ";
        }
        return result;
    }


    string NumbersRec(int a, int b)
    {
        if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
        else return String.Empty;
    }

    Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
    Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10
}





/*
Собрать строку с числами от a до b, a ≥ b

*/

void Task2()
{
    string NumbersFor(int a, int b)
    {
        string result = String.Empty;
        for (int i = b; i >= a; i--)
        {
            result += $"{i} ";
        }
        return result;
    }


    string NumbersRec(int a, int b)
    {
        if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
        else return String.Empty;
    }

    Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
    Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

}





/*
Сумма чисел от 1 до n

*/

void Task3()
{
    int SumFor(int n)
    {
        int result = 0;
        for (int i = 1; i <= n; i++) result += i;
        return result;
    }


    int SumRec(int n)
    {
        if (n == 0) return 0;
        else return n + SumRec(n - 1);
    }

    Console.WriteLine(SumFor(10)); // 55
    Console.WriteLine(SumRec(10)); // 55

}





/*
Факториал числа
*/

void Task4()
{
    int FactorialFor(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++) result *= i;
        return result;
    }


    int FactorialRec(int n)
    {
        if (n == 1) return 1;
        else return n * FactorialRec(n - 1);
    }

    Console.WriteLine(FactorialFor(10)); // 3628800
    Console.WriteLine(FactorialRec(10)); // 3628800

}





/*
Вычислить а^n

*/

void Task5()
{
    int PowerFor(int a, int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++) result *= a;
        return result;
    }


    int PowerRec(int a, int n)
    {
        return n == 0 ? 1 : PowerRec(a, n - 1) * a;
        // if (n == 0) return 1;
        // else return PowerRec(a, n - 1) * a;
    }


    int PowerRecMath(int a, int n)
    {
        if (n == 0) return 1;
        else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
        else return PowerRecMath(a, n - 1) * a;
    }

    Console.WriteLine(PowerFor(2, 10)); // 1024
    Console.WriteLine(PowerRec(2, 10)); // 1024
    Console.WriteLine(PowerRecMath(2, 10)); // 1024

}





/*
Перебор слов
В некотором машинном алфавите имеются четыре
буквы «а», «и», «с» и «в». 
Покажите все слова, состоящие из T букв, 
которые можно построить из букв этого алфавита

*/

void Task6()
{
    int n = 1;
    void FindWords(string alphabet, char[] word, int length = 0)
    {
        if (length == word.Length)
        {
            Console.WriteLine($"{n++} {new String(word)}"); return;
        }
        for (int i = 0; i < alphabet.Length; i++)
        {
            word[length] = alphabet[i];
            FindWords(alphabet, word, length + 1);
        }
    }

    FindWords("аисв", new char[2]);

}





/*
Как посмотреть содержимое папки?

*/

void Task7()
{
    string path1 = "D:/Education/project/C#/Examples/Example002_HelloUser";
    DirectoryInfo di = new DirectoryInfo(path1);
    Console.WriteLine(di.CreationTime);
    FileInfo[] fi = di.GetFiles();

    for (int i = 0; i < fi.Length; i++)
    {
        Console.WriteLine(fi[i].Name);
    }


    // Рекурсия
    void CatalogInfo(string path, string indent = "")
    {
        DirectoryInfo catalogs = new DirectoryInfo(path);
        foreach (var currentCatalog in catalogs.GetDirectories())
        {
            Console.WriteLine($"{indent}{currentCatalog.Name}");
            CatalogInfo(currentCatalog.FullName, indent + " ");
        }
        foreach (var item in catalogs.GetFiles())
        {
            Console.WriteLine($"{indent}{item.Name}");
        }
    }
    string path2 = "D:/Education/project/C#/Examples/Example002_HelloUser";
    CatalogInfo(path2);

}





/*
Игра в пирамидки

http://rebus1.com/index.php?item=tower

*/

void Task8()
{
    void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
    {
        if (count > 1) Towers(with, some, on, count - 1);
        Console.WriteLine($"{with} >> {on}");
        if (count > 1) Towers(some, on, with, count - 1);
    }

    Towers();
}





/*
Обход разных структур

*/

void Task9()
{
    string emp = String.Empty;
    string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
    //                 0    1    2     3    4    5    6    7    8    9    10   11

    void InOrderTraversal(int pos = 1)
    {
        if (pos < tree.Length)
        {
            int left = 2 * pos;
            int right = 2 * pos + 1;
            if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
            Console.WriteLine(tree[pos]);
            if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
        }

    }
    InOrderTraversal();
}





// Task1();
// Task2();
// Task3();
// Task4();
// Task5();
// Task6();
// Task7();
// Task8();
// Task9();
