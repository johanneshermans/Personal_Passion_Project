using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MaterialSelector))]
public class ControlOrganic : MonoBehaviour
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
    }

    public void SetTextures(Model model)
    {
        GameObject moon = GameObject.FindGameObjectWithTag("Moon");
        GameObject[] bows = GameObject.FindGameObjectsWithTag("Bow");
        GameObject[] brain = GameObject.FindGameObjectsWithTag("Brain");
        GameObject bigPyro = GameObject.FindGameObjectWithTag("BigPyro");
        GameObject[] floorOrganic = GameObject.FindGameObjectsWithTag("FloorOrganic");
        GameObject[] pyro1 = GameObject.FindGameObjectsWithTag("Pyro1");
        GameObject[] pyro2 = GameObject.FindGameObjectsWithTag("Pyro2");
        GameObject[] pyro3 = GameObject.FindGameObjectsWithTag("Pyro3");
        Color color1 = getNewColor.ReturnColor(model.color1);
        Color color2 = getNewColor.ReturnColor(model.color2);
        Color color3 = getNewColor.ReturnColor(model.color3);


        moon.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);
        bigPyro.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        foreach (GameObject bow in bows)
        {
            bow.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex2);
        }

        foreach (GameObject brai in brain)
        {
            brai.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex3);
        }

        foreach (GameObject floor in floorOrganic)
        {
            floor.GetComponent<MeshRenderer>().material = matSelector.GetMaterial(model.tex1);
        }

        foreach (GameObject cone in pyro1)
        {
            cone.GetComponent<Renderer>().material.color = color1;
        }

        foreach (GameObject cone in pyro2)
        {
            cone.GetComponent<Renderer>().material.color = color2;
        }

        foreach (GameObject cone in pyro3)
        {
            cone.GetComponent<Renderer>().material.color = color3;
        }
    }
}
