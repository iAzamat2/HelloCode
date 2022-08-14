namespace FunctionsOfArray
{
    public class FunctionsOfArrayClass
    {
        public void Solve(double a, double b, double c)
        {
            var d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
        }

        

        public void cls()
        {
            Console.Clear();
        }







    }




}