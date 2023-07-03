using Files;
using System.Security.Cryptography.X509Certificates;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
public abstract class Shakllar<T>
{
    public virtual void FindSurface(T a, T b)
    {
        Console.WriteLine();
    }
}
public class Uchburchak<T> : Shakllar<double>
{
    public override void FindSurface(double a, double b)
    {
        Console.WriteLine($"Uchburchak yuzasi : {(a / 2) * b}");
    }
}
public class Aylana : Shakllar<int>
{
    public override void FindSurface(int a, int b)
    {
        Console.WriteLine($"Aylana yuzasi : {b * (a * a)}");
    }
}
public class TogriTortburchak : Shakllar<float>
{
    public override void FindSurface(float a, float b)
    {
        Console.WriteLine($"To'rtburchak yuzasi: {a * b}");
    }
}