using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public bool hasItem = false;
    public GameObject spwn;
    public GameObject inventoryController;

    void Start()

    {
        hasItem = false;        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;

        if (collision.tag == "item")
        {
            Debug.Log("Item picked up!");
            hasItem = true;
            Destroy(other);
        }

        if(collision.tag == "damager")
        {
            inventoryController.GetComponent<InventoryController>().takeDamage();
            Destroy(other);
        }
        
        if (collision.tag == "box")
        {
            if (hasItem)
            {
                inventoryController.GetComponent<InventoryController>().addItem();
                hasItem = false;
                spwn.GetComponent<GameSpawner>().SpawnItem();
            }
        }
    }
}
