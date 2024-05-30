namespace TRPO_Lab3.Lib
{
    namespace TRPO_Lab3.Lib
    {
        public class SurfaceArea
        {
            public static double TruncatedPyramidLateralSurfaceArea(double P1, double P2, double h)
            {
                try
                {
                    if (P1 >= 0 && P2 >= 0 && h >= 0)
                    {
                        double surfaceArea = 0.5 * (P1 + P2) * h;
                        surfaceArea = Math.Round(surfaceArea, 3);
                        return surfaceArea;
                    }
                    else
                    {
                        throw new Exception("Значения периметров и высоты не могут быть отрицательными!");
                    }
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
    }
}