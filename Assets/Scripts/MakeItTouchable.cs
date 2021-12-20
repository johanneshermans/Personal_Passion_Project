using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class MakeItTouchable : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public HandleScoreboard handleScore;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                handleScore.UpdateScore();
                Destroy(hit.collider.gameObject); 
            }
        }
    }

}
