using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadEventSystem : MonoBehaviour
{
    private static DontDestroyOnLoadEventSystem instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
