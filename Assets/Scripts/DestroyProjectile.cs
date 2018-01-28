using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;

        if (collision.tag == "wall")
        {
            Destroy(gameObject);
        }
    }
}
