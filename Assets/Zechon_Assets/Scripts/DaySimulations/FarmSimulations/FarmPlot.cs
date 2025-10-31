using UnityEngine;

public class FarmPlot
{
    public int width = 9;
    public int height = 9;
    public Crop[,] crops;
    public Vector2Int waterPos = new Vector2Int(4, 4);

    public FarmPlot()
    {
        crops = new Crop[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == waterPos.x && y == waterPos.y)
                    crops[x, y] = null; // no crop
                else
                    crops[x, y] = new Crop();
            }
        }
    }
}
