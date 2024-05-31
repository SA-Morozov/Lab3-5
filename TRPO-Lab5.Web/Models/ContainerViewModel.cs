using TRPO_Lab3.Lib.TRPO_Lab3.Lib;

public class ContainerViewModel
{
    public double P1 { get; set; } // Периметр нижнего основания
    public double P2 { get; set; } // Периметр верхнего основания
    public double H { get; set; }  // Апофема (высота боковой грани)

    public double Result => SurfaceArea.TruncatedPyramidLateralSurfaceArea(P1, P2, H);
}