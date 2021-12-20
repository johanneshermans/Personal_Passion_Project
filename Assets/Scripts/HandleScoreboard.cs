using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(TMPro.TextMeshPro))]
public class HandleScoreboard : MonoBehaviour
{

    public int Score;
    TMPro.TextMeshPro textComp;

    public void UpdateScore()
    {
        ++Score;
        Debug.Log(Score);
        textComp.text = Score.ToString();
    }

    void Start()
    {
        textComp = gameObject.GetComponent<TMPro.TextMeshPro>();
        textComp.text = Score.ToString();
    }
}
