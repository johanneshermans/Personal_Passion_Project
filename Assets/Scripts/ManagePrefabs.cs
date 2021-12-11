using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePrefabs : MonoBehaviour
{
    [SerializeField] private GameObject StageGameObject;
    [SerializeField] private GameObject VibesGameObject;
    [SerializeField] private GameObject OrganicGameObject;

    public enum Worlds
        {
            none,
            stage,
            vibes,
            organic
        }
    private GameObject currentObject;
    private Worlds currentWorld;


    public void start()
    {
        Worlds myWorlds;
        myWorlds = Worlds.vibes;
        ChangeWorlds(myWorlds);
    }

    private void ChangeWorlds(Worlds world)
    {
        if (world == currentWorld)
            return;

        if (world == Worlds.stage)
        {
            Debug.Log("show Stage");
            currentObject = Instantiate(StageGameObject,gameObject.transform);
            currentWorld = Worlds.stage;
        }
        else if (world == Worlds.vibes)
        {
            Debug.Log("show vibes");
            currentObject = Instantiate(VibesGameObject, gameObject.transform);
            currentWorld = Worlds.vibes;

        }
        else if (world == Worlds.organic)
        {
            Debug.Log("show map");
            currentObject = Instantiate(OrganicGameObject,gameObject.transform);
            currentWorld = Worlds.organic;
        }
    }

}
