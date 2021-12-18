using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{

    GUIContent content;
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
        style.normal.textColor = Color.red;
        style.fontStyle = FontStyle.Bold;
        GUI.Button(new Rect(Screen.width - 250, Screen.height - 60, 200, 50), "Restart experience", style);
    }
}
