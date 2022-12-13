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
        gameManager.InitButtonListeners();
    }

}
