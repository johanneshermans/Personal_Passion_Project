using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Color ReturnedColor;

    public Color ReturnColor(string color)
    {
        Color newCol;
        if (ColorUtility.TryParseHtmlString(color, out newCol))
            ReturnedColor = newCol;
        return ReturnedColor;
    }

}
