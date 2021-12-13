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


    public void SetTextures(Model model)
    {
        //GameObject moon = GameObject.FindGameObjectWithTag("Moon");
        GameObject[] bows = GameObject.FindGameObjectsWithTag("Bow");
        GameObject[] brain = GameObject.FindGameObjectsWithTag("Brain");
        //GameObject bigPyro = GameObject.FindGameObjectWithTag("BigPyro");
        GameObject[] floorOrganic = GameObject.FindGameObjectsWithTag("FloorOrganic");
        GameObject[] pyro1 = GameObject.FindGameObjectsWithTag("Pyro1");
        GameObject[] pyro2 = GameObject.FindGameObjectsWithTag("Pyro2");
        GameObject[] pyro3 = GameObject.FindGameObjectsWithTag("Pyro3");


        Debug.Log(model.color1);

        foreach (GameObject bow in bows)
        {
            bow.GetComponent<MeshRenderer>().material = glossy;
        }

        foreach (GameObject brai in brain)
        {
            brai.GetComponent<MeshRenderer>().material = glossy;
        }

        foreach (GameObject floor in floorOrganic)
        {
            floor.GetComponent<MeshRenderer>().material = metal;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
