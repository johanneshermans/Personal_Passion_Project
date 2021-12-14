using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVibes : MonoBehaviour
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

        Debug.Log(model.color1);

        foreach (GameObject floor in floorVibes)
        {
            floor.GetComponent<MeshRenderer>().material = GetMaterial(model.tex1);
        }

        foreach (GameObject bol in clockBolls)
        {
            bol.GetComponent<MeshRenderer>().material = GetMaterial(model.tex1);
        }

        foreach (GameObject crow in crows)
        {
            crow.GetComponent<MeshRenderer>().material = GetMaterial(model.tex2);
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

    Material GetMaterial(string materialName)
    {
        switch (materialName)
        {
            case "hardwood":
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
