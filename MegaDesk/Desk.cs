using System;

public class Desk
{
    /*************************
    * Create Class Variables * 
    *************************/
    public enum SurfaceMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public enum RushOrderDays
    {
        None = 14,
        Three = 3,
        Five = 5,
        Seven = 7
    }

    public const int MIN_WIDTH = 24;
    public const int MAX_WIDTH = 96;
    public const int MIN_DEPTH = 12;
    public const int MAX_DEPTH = 48;
    public int Width { get; set; }
    public int Depth { get; set; }
    public int NoOfDrawers { get; set; }
    public SurfaceMaterial Material { get; set; }
    public RushOrderDays Days { get; set; }

	public Desk()
	{        
        // No constructor method
	}
}
