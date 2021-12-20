using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSelector : MonoBehaviour {

    public Material hardwood;
    public Material glossy;
    public Material lava;
    public Material metal;
    public Material muddy;
    public Material paper;
    public Material slime;
    public Material space;
    public Material spaced;
    public Material standard;
    public Material GetMaterial(string materialName)
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
        return standard;

    }
}
