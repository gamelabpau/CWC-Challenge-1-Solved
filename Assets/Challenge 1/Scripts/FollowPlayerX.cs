using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(15,0,0);
    private Vector3 offset2 = new Vector3(0,3,8);

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetLevel() == 1)
        {
            transform.position = plane.transform.position + offset;
        }
        else if (gameManager.GetLevel() == 2)
        {
            transform.position = plane.transform.position + offset2;
        }
    }
}
