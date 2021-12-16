using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    float originalY;
    [SerializeField] public float floatStrength;

    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, 0.2f + (.2f * Mathf.Sin(Time.time) * floatStrength), transform.position.z);
    }
}


