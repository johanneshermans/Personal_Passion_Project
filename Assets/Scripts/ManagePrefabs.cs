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

    // Start is called before the first frame update
    void Start()
    {
        Worlds myWorlds;

        myWorlds = Worlds.organic;
        ChangeWorlds(myWorlds);
    }

    void ChangeWorlds(Worlds world)
    {
        if (world == currentWorld)
            return;

        if (world == Worlds.stage)
        {
            Debug.Log("show Stage");
            currentObject = Instantiate(StageGameObject);
            currentWorld = Worlds.stage;
        }
        else if (world == Worlds.vibes)
        {
            Debug.Log("show vibes");
            currentObject = Instantiate(VibesGameObject);
            currentWorld = Worlds.vibes;

        }
        else if (world == Worlds.organic)
        {
            Debug.Log("show map");
            currentObject = Instantiate(OrganicGameObject);
            currentWorld = Worlds.organic;
        }
    }

}
