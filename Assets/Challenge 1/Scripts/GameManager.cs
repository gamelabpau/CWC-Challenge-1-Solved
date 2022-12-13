using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int vidas = 3;
    [SerializeField] private int level = 1;
    
    private static GameManager instance;

    //[SerializeField] public List<GameObject> lifesUI = new List<GameObject>();
    [SerializeField] private GameObject life1;
    [SerializeField] private GameObject life2;
    [SerializeField] private GameObject life3;
    
    // [SerializeField] private List<Image> lifesUIImages;
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

    public int GetLevel()
    {
        return level;
    }
    
    public void FinLevel1()
    {
        // Mostrar botón continuar al siguiente nivel
        level = 2;
        SceneManager.LoadScene("Level 2");
    }

    public void AddVida()
    {
        if (vidas < 3)
        {
            // lifesUI[vidas].gameObject.SetActive(false);
            vidas++;
        }
    }
    
    public void RestarVida()
    {
        vidas--;

        if (vidas == 2)
        {
            life3.SetActive(false);
        }
        else if (vidas == 1)
        {
            life2.SetActive(false);
        }
        else if (vidas == 0)
        {
            life1.SetActive(false);
        }
        
        // Destroy(lifesUI[vidas]);
        // if (lifesUI[vidas] != null)
        // {
        //     lifesUI[vidas].gameObject.SetActive(false);
        // }
        // lifesUIImages[vidas].enabled = false;
        
        if (vidas <= 0)
        {
            // GameOver
            GameOver();
        }
        else
        {
            Debug.Log(vidas);
            // Reiniciar nivel  
            if (level == 1)
            {
                SceneManager.LoadScene("Level 1");
            }
            else if (level == 2)
            {
                SceneManager.LoadScene("Level 2");
            }
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0f;
        // Cargar Escena GameOver
    }
}
