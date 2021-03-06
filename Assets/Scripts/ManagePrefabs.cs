using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePrefabs : MonoBehaviour
{
    [SerializeField] private GameObject StageGameObject;
    [SerializeField] private GameObject VibesGameObject;
    [SerializeField] private GameObject OrganicGameObject;
    public ControlOrganic controlOrganic;
    public ControlVibes controlVibes;
    public ControlStage controlStage;

    public enum Worlds
        {
            none,
            stage,
            vibes,
            organic
        }
    private GameObject currentObject;
    private Worlds currentWorld = Worlds.none;

    private void Start()
    {
        GetData.managePrefabs = this;
     }
     
    public void ChangeWorlds(string model, Model world)
    {
        
        if (model == currentWorld.ToString())
        {
            return;
        }

        Destroy(currentObject);
       
        if (model == "stage")
        {
            currentObject = Instantiate(StageGameObject,gameObject.transform);
            currentWorld = Worlds.stage;
            controlStage.SetTextures(world);
        }
        else if (model == "vibes")
        {
            currentObject = Instantiate(VibesGameObject, gameObject.transform);
            currentWorld = Worlds.vibes;
            controlVibes.SetTextures(world);
            Debug.Log("4");


        }
        else if (model == "organic")
        {
            currentObject = Instantiate(OrganicGameObject,gameObject.transform);
            currentWorld = Worlds.organic;
            controlOrganic.SetTextures(world);
        }
    }

    public void Reset()
    {
        Debug.Log("Reset model");
        Destroy(currentObject);
    }

}
