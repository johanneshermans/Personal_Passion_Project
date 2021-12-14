using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlOrganic : MonoBehaviour
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


    public void SetTextures(Model model, int bpm)
    {
        GameObject moon = GameObject.FindGameObjectWithTag("Moon");
        GameObject[] bows = GameObject.FindGameObjectsWithTag("Bow");
        GameObject[] brain = GameObject.FindGameObjectsWithTag("Brain");
        //GameObject bigPyro = GameObject.FindGameObjectWithTag("BigPyro");
        GameObject[] floorOrganic = GameObject.FindGameObjectsWithTag("FloorOrganic");
        GameObject[] pyro1 = GameObject.FindGameObjectsWithTag("Pyro1");
        GameObject[] pyro2 = GameObject.FindGameObjectsWithTag("Pyro2");
        GameObject[] pyro3 = GameObject.FindGameObjectsWithTag("Pyro3");


        Debug.Log(model.tex1);
        Rotate(moon, bpm);

        foreach (GameObject bow in bows)
        {
            bow.GetComponent<MeshRenderer>().material = GetMaterial(model.tex1);
        }

        foreach (GameObject brai in brain)
        {
            brai.GetComponent<MeshRenderer>().material = GetMaterial(model.tex2);
        }

        foreach (GameObject floor in floorOrganic)
        {
            floor.GetComponent<MeshRenderer>().material = GetMaterial(model.tex2);
        }

        foreach (GameObject cone in pyro1)
        {
            cone.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }

        foreach (GameObject cone in pyro2)
        {
            cone.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }

        foreach (GameObject cone in pyro3)
        {
            cone.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }
    }

    void Rotate(GameObject part, int bpm)
    {
        Debug.Log(bpm);
    }

    Material GetMaterial(string materialName)
    {
        switch(materialName)
        { case "hardwood":
                return hardwood;

            case "glossy":
                return glossy;

            case "lava":
                return lava;

            case "metal":
                return metal;

            case "muddy":
                return muddy;

            case "paper":
                return paper;

            case "slime":
                return slime;

            case "space":
                return space;

            case "spaced":
                return spaced;
        }
        return default;
        
    }

}
