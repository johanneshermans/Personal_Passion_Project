using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenText : MonoBehaviour
{
    GUIStyle style = new GUIStyle();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        style.fontSize = 20;
        style.normal.textColor = Color.white;
        style.fontStyle = FontStyle.Bold;
        GUI.Box(new Rect(10, 10, 400, 50), "Scan the Image tag to start the experience", style);
    }
}
