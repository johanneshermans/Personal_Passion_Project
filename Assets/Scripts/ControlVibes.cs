using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MaterialSelector))]
public class ControlVibes : MonoBehaviour
{
    private MaterialSelector matSelector;
    void Start()
    {
        matSelector = FindObjectOfType<MaterialSelector>();
        if (!matSelector)
        {
            Exception exception = new Exception("No materialSelector found");
            Debug.LogException(exception);
        }
    }

    public void SetTextures(Model model, int bpm)
    {

        GameObject[] floorVibes = GameObject.FindGameObjectsWithTag("FloorVibes");
        GameObject[] clockBolls = GameObject.FindGameObjectsWithTag("ClockBolls");
        GameObject[] crows = GameObject.FindGameObjectsWithTag("Crows");
        //GameObject vibes = GameObject.FindGameObjectWithTag("Vibes");
        GameObject[] spiral = GameObject.FindGameObjectsWithTag("Spiral");
        GameObject[] pyra1 = GameObject.FindGameObjectsWithTag("Pyra1");
        GameObject[] pyra2 = GameObject.FindGameObjectsWithTag("Pyra2");
        GameObject[] pyra3 = GameObject.FindGameObjectsWithTag("Pyra3");
        //GameObject magicBall = GameObject.FindGameObjectWithTag("MagicBall");
        GameObject[] treeLevel = GameObject.FindGameObjectsWithTag("TreeLevel");

        Debug.Log(floorVibes.Length);
        foreach (GameObject floor in floorVibes)
        {
            floor.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        }

        foreach (GameObject bol in clockBolls)
        {
            bol.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        }

        foreach (GameObject crow in crows)
        {
            crow.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex2);
        }

        foreach (GameObject spi in spiral)
        {
            spi.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }

        foreach (GameObject pyra in pyra1)
        {
            pyra.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }

        foreach (GameObject pyra in pyra2)
        {
            pyra.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }

        foreach (GameObject pyra in pyra3)
        {
            pyra.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }

        foreach (GameObject tree in treeLevel)
        {
            tree.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }
    }
}
