using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitL2 : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        // gameManager.lifesUI.Clear();
        List<GameObject> vidasActivas = new List<GameObject>();
        GameObject[] vidas = GameObject.FindGameObjectsWithTag("Vida");
        foreach (GameObject vida in vidas)
        {
            if (vida.activeInHierarchy)
            {
                // gameManager.lifesUI.Add(vida);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
