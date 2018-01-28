using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour {
    public GameObject[] itemSpawns;
    public GameObject[] item;

	void Start()
    {		
        SpawnItem();
    }

	public void SpawnItem()
    {
		// Randomly selects item (default item / skull / etc.)
		int type = Random.Range(0, item.Length);

		// Randomly selects respawn position
		int roll = Random.Range(0, itemSpawns.Length);
	
		// Gets position
        Vector2 itemPos = itemSpawns[roll].transform.position;

		// Initiates new object
        Instantiate(item[type], itemPos, Quaternion.identity);
    }
}
