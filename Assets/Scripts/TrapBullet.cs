using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBullet : MonoBehaviour {

    public GameObject bullet;
    private GameObject newBullet;

    public enum Direction
    {
        Left, Right, Up, Down
    }

    public Direction projectileDir;
    public float bulletSpeed = 3f;

    public float timeInterval = 3;

    void Start() {
        StartCoroutine(SpawnDelay(5.5f));
    }

    void SpawnBullet()
    {
        Vector2 position = transform.position;
        newBullet = Instantiate(bullet, position, Quaternion.identity);

        switch (projectileDir)
        {
            case Direction.Left:
                newBullet.GetComponent<MoveProjectile>().projectileDir = MoveProjectile.Direction.Left;
                break;

            case Direction.Right:
                newBullet.GetComponent<MoveProjectile>().projectileDir = MoveProjectile.Direction.Right;
                break;

            case Direction.Up:
                newBullet.GetComponent<MoveProjectile>().projectileDir = MoveProjectile.Direction.Up;
                break;

            case Direction.Down:
                newBullet.GetComponent<MoveProjectile>().projectileDir = MoveProjectile.Direction.Down;
                break;
        }

        newBullet.GetComponent<MoveProjectile>().bulletSpeed = bulletSpeed;
        StartCoroutine(SpawnDelay(timeInterval));
    }

    IEnumerator SpawnDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SpawnBullet();
    }
}
