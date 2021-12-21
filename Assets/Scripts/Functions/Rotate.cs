using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private int bpm;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * bpm, 0);
    }
}
