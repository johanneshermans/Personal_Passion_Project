using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent (typeof (Button))]
public class RestartButton : MonoBehaviour
{
    
    GUIContent content;
    GUIStyle style = new GUIStyle();
   // [SerializeField] private LoadOnlineVideo currentVideoClip;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ResetSystem);
        

    }

    public void ResetSystem()
    {
        Debug.Log("Reset");
        GetData.Reset();
        button.onClick.AddListener(ResetSystem);
    }

    
}
