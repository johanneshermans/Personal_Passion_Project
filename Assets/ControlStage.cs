using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStage : MonoBehaviour
{
    public Material hardwood;
    public Material glossy;
    public Material lava;
    public Material metal;
    public Material muddy;
    public Material paper;
    public Material slime;
    public Material space;
    public Material spaced;
    // Start is called before the first frame update
    void Start()
    {


    }

    void SetTextures()
    {
        GameObject[] bigCubes = GameObject.FindGameObjectsWithTag("Bigcubes");
        GameObject[] normalCube = GameObject.FindGameObjectsWithTag("Normalcube");
        GameObject[] smallCube = GameObject.FindGameObjectsWithTag("Smallcube");
        //GameObject topring = GameObject.FindGameObjectWithTag("Topring");
        //GameObject top = GameObject.FindGameObjectWithTag("Top");
        //GameObject stage = GameObject.FindGameObjectWithTag("Stage");
        //GameObject plane = GameObject.FindGameObjectWithTag("Plane");
        //GameObject podium = GameObject.FindGameObjectWithTag("Podium");
        GameObject[] bol1 = GameObject.FindGameObjectsWithTag("Bol1");
        GameObject[] bol2 = GameObject.FindGameObjectsWithTag("Bol2");
        GameObject[] bol3 = GameObject.FindGameObjectsWithTag("Bol3");




        foreach (GameObject cube in bigCubes)
        {
            cube.GetComponent<MeshRenderer>().material = glossy;
        }

        foreach (GameObject cube in normalCube)
        {
            cube.GetComponent<MeshRenderer>().material = lava;
        }

        foreach (GameObject cube in smallCube)
        {
            cube.GetComponent<MeshRenderer>().material = metal;
        }

        foreach (GameObject bol in bol1)
        {
            bol.GetComponent<MeshRenderer>().material = muddy;
        }

        foreach (GameObject bol in bol2)
        {
            bol.GetComponent<MeshRenderer>().material = paper;
        }

        foreach (GameObject bol in bol3)
        {
            bol.GetComponent<MeshRenderer>().material = slime;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
