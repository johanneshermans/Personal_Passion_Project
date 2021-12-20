using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereSpawner: MonoBehaviour
{
	[SerializeField] private GameObject GO;
	[SerializeField] private float spawnTime = 2f;
	[SerializeField] private HandleScoreboard handleScore;

	private float spawnTimer = 0f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		spawnTimer += Time.deltaTime;
		if (spawnTimer >= spawnTime)
		{
			Vector3 pos = new Vector3(0, 0, 0);
			pos.x = Random.Range(-50, 50);
			pos.y = Random.Range(-50, 50);
			pos.z = Random.Range(-50, 50);
			GameObject newObj = Instantiate(GO, pos, gameObject.transform.rotation);
			MakeItTouchable comp = newObj.GetComponent<MakeItTouchable>();
			if(!comp)
            {
				Debug.LogError("No makeIttouchableComp detected");
				return;
            }
			comp.handleScore = handleScore;
			Debug.Log("Sphere spawned at x =" + pos.x.ToString());
			spawnTimer = 0f;
			
		}

	}
}
