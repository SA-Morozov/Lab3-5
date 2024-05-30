using TRPO_Lab3.Lib.TRPO_Lab3.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("P1-периметр нижнего основания = ");
            double P1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("P2— периметр верхнего основания = ");
            double P2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("h — апофема (высота боковой грани) = ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("боковая поверхность правильной усеченной пирамиды " + SurfaceArea.TruncatedPyramidLateralSurfaceArea(P1, P2, h));
            Console.ReadKey();
        }
    }
}
