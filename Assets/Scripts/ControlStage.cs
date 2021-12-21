using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MaterialSelector))]
public class ControlStage : MonoBehaviour
{
    private MaterialSelector matSelector;
    private ChangeColor getNewColor;

    void Start()
    {
       matSelector = FindObjectOfType<MaterialSelector>();
        if (!matSelector)
        {
            Exception exception = new Exception ( "No materialSelector found");
            Debug.LogException(exception);
        }
        getNewColor = new ChangeColor();
    }

    public void SetTextures(Model model)
    {
        GameObject[] bigCubes = GameObject.FindGameObjectsWithTag("Bigcubes");
        GameObject[] normalCube = GameObject.FindGameObjectsWithTag("Normalcube");
        GameObject[] smallCube = GameObject.FindGameObjectsWithTag("Smallcube");
        GameObject topring = GameObject.FindGameObjectWithTag("Topring");
        GameObject top = GameObject.FindGameObjectWithTag("Top");
        GameObject[] stages = GameObject.FindGameObjectsWithTag("Stage");
        GameObject plane = GameObject.FindGameObjectWithTag("Plane");
        GameObject podium = GameObject.FindGameObjectWithTag("Podium");
        GameObject headCube = GameObject.FindGameObjectWithTag("Headcube");
        GameObject[] bol1 = GameObject.FindGameObjectsWithTag("Bol1");
        GameObject[] bol2 = GameObject.FindGameObjectsWithTag("Bol2");
        GameObject[] bol3 = GameObject.FindGameObjectsWithTag("Bol3");
        Color color1 = getNewColor.ReturnColor(model.color1);
        Color color2 = getNewColor.ReturnColor(model.color2);
        Color color3 = getNewColor.ReturnColor(model.color3);


        topring.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);
        top.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);
        
        plane.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        podium.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        headCube.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);


        foreach (GameObject cube in bigCubes)
        {
            cube.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex2);
        }

        foreach (GameObject stage in stages )
        {
            stage.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);
        }

        foreach (GameObject cube in normalCube)
        {
            cube.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex2);
        }

        foreach (GameObject cube in smallCube)
        {
            cube.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex2);
        }

        foreach (GameObject bol in bol1)
        {
            bol.GetComponent<Renderer>().material.color = color1;
        }

        foreach (GameObject bol in bol2)
        {
            bol.GetComponent<Renderer>().material.color = color2;
        }

        foreach (GameObject bol in bol3)
        {
            bol.GetComponent<Renderer>().material.color = color3;
        }
    }

   


}
