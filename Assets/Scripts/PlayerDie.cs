using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour {
    private Vector2 respawnPos;
    private GameObject player;
    public float respawnDelay = 1f;
    public GameObject gameCamera;
    public GameObject spawnController;
    public GameObject inventoryController;

    void Awake () {
        respawnPos = gameObject.transform.position;
        player = gameObject;
    }

    void Update () {
        Vector2 currentPos = player.transform.position;

        if (currentPos.y <= -200)
        {
            inventoryController.GetComponent<InventoryController>().takeDamage();
            Destroy(player, 2f);
            currentPos = new Vector2(0f, 0f);
            Respawn();
        }

    }

    void Respawn()
    {
        player = Instantiate(gameObject, respawnPos, Quaternion.identity);
        gameCamera.GetComponent<CameraController>().RefocusTo(player);
        gameObject.GetComponent<Inventory>().hasItem = false;

        if(player.GetComponent<Inventory>().hasItem == true)
        {
            spawnController.GetComponent<GameSpawner>().SpawnItem();
        }

        int items = inventoryController.GetComponent<InventoryController>().items;
        if(items > 0)
        {
            inventoryController.GetComponent<InventoryController>().minusItem();
        }
    }
}
