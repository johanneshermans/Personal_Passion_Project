using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MaterialSelector))]
public class ControlVibes : MonoBehaviour
{
    private MaterialSelector matSelector;
    private ChangeColor getNewColor;
    void Start()
    {
        matSelector = FindObjectOfType<MaterialSelector>();
        if (!matSelector)
        {
            Exception exception = new Exception("No materialSelector found");
            Debug.LogException(exception);
        }
        getNewColor = new ChangeColor();
    }

    public void SetTextures(Model model)
    {

        GameObject[] floorVibes = GameObject.FindGameObjectsWithTag("FloorVibes");
        GameObject[] clockBolls = GameObject.FindGameObjectsWithTag("ClockBolls");
        GameObject[] crows = GameObject.FindGameObjectsWithTag("Crows");
        GameObject vibes = GameObject.FindGameObjectWithTag("Vibes");
        GameObject[] spiral = GameObject.FindGameObjectsWithTag("Spiral");
        GameObject[] pyra1 = GameObject.FindGameObjectsWithTag("Pyra1");
        GameObject[] pyra2 = GameObject.FindGameObjectsWithTag("Pyra2");
        GameObject[] pyra3 = GameObject.FindGameObjectsWithTag("Pyra3");
        GameObject magicBall = GameObject.FindGameObjectWithTag("MagicBall");
        GameObject[] treeLevel = GameObject.FindGameObjectsWithTag("TreeLevel");
        Color color1 = getNewColor.ReturnColor(model.color1);
        Color color2 = getNewColor.ReturnColor(model.color2);
        Color color3 = getNewColor.ReturnColor(model.color3);
        Debug.Log(model.tex3);
        Debug.Log(color1);


        vibes.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);
        magicBall.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);

        foreach (GameObject floor in floorVibes)
        {
            floor.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        }

        foreach (GameObject bol in clockBolls)
        {
            bol.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex2);
        }

        foreach (GameObject crow in crows)
        {
            crow.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);
        }

        foreach (GameObject spi in spiral)
        {
            spi.GetComponent<Renderer>().material.color = color1;
        }

        foreach (GameObject pyra in pyra1)
        {
            pyra.GetComponent<Renderer>().material.color = color2;
        }

        foreach (GameObject pyra in pyra2)
        {
            pyra.GetComponent<Renderer>().material.color = color3;
        }

        foreach (GameObject pyra in pyra3)
        {
            pyra.GetComponent<Renderer>().material.color = color1;
        }

        foreach (GameObject tree in treeLevel)
        {
            tree.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);
        }
    }
}
