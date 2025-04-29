using Unity.VisualScripting;
using UnityEngine;

public static class ColorExtension
{
    public static Color ToDarkGreen(this Color color)
    {
        return new Color(0.33f, 0.66f, 0.33f);
    }
}
