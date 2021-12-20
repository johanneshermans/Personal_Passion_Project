using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MaterialSelector))]
public class ControlStage : MonoBehaviour
{
    private MaterialSelector matSelector;

    void Start()
    {
       matSelector = FindObjectOfType<MaterialSelector>();
        if (!matSelector)
        {
            Exception exception = new Exception ( "No materialSelector found");
            Debug.LogException(exception);
        }
    }

    public void SetTextures(Model model)
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

        Debug.Log(model.color1);


        foreach (GameObject cube in bigCubes)
        {
            cube.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        }

        foreach (GameObject cube in normalCube)
        {
            cube.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        }

        foreach (GameObject cube in smallCube)
        {
            cube.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex2);
        }

        foreach (GameObject bol in bol1)
        {
            bol.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }

        foreach (GameObject bol in bol2)
        {
            bol.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }

        foreach (GameObject bol in bol3)
        {
            bol.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }
    }

   


}
