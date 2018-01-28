using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour {
    public int items = 0;
    public int lives = 3;
    public Text itemsScore;
    public Text livesScore;

    private void Start()
    {
        setLives(3);
        items = 0;
        lives = 3;
    }

    public void addItem()
    {
        items++;
        itemsScore.text = items.ToString();
        Debug.Log("Items: " + items);
    }

    public void minusItem()
    {
        items--;
        itemsScore.text = items.ToString();
        Debug.Log("Items: " + items);
    }

    public void setLives(int lives)
    {
        this.lives = lives;
        livesScore.text = lives.ToString();
    }

    public void takeDamage()
    {
        if(lives > 0)
        {
            lives--;
            livesScore.text = lives.ToString();
        }
        else
        {
            gameOver();
        }
    }

    public void levelCleared()
    {
        if(items == 20)
        {
            // TO-DO... level cleared script
        }
    }

    public void gameOver()
    {
        // TO-DO... game over script
    }
}
