using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Die. Resta una vida o game over.
            gameManager.RestarVida();
        }
        else if (collision.gameObject.name.Equals("Meta"))
        {
            if (gameManager.GetLevel() == 1)
                gameManager.FinLevel1();
            else if (gameManager.GetLevel() == 2)
            {
                gameManager.GameOver();
            }
        }
    }
    
}
