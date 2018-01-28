using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour {

    public enum Direction
    {
        Left, Right, Up, Down
    }

    public float bulletSpeed = 3f;
    public Direction projectileDir;

    void FixedUpdate () {
        Move(projectileDir);
	}

    void Move(Direction dir)
    {
        Vector2 position = transform.position;

        switch (dir)
        {
            case Direction.Left:
                position = new Vector2(position.x - bulletSpeed * Time.deltaTime, position.y);
                break;

            case Direction.Right:
                position = new Vector2(position.x + bulletSpeed * Time.deltaTime, position.y);
                break;

            case Direction.Up:
                position = new Vector2(position.x, position.y + bulletSpeed * Time.deltaTime);
                break;

            case Direction.Down:
                position = new Vector2(position.x, position.y - bulletSpeed * Time.deltaTime);
                break;
        }

        transform.position = position;
    }
}
