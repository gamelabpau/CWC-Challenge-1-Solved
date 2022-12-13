using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private Button restartLevelButton;

    [SerializeField] private int vidas = 3;
    [SerializeField] private int level = 1;
    
    private static GameManager instance;

    [SerializeField] public List<GameObject> lifesUI;

    private void Start()
    { 
        InitButtonListeners();
        InitLevel();
    }

    public void InitButtonListeners()
    {
        nextLevelButton.onClick.RemoveAllListeners();
        nextLevelButton.onClick.AddListener(NextLevel);
        restartLevelButton.onClick.RemoveAllListeners();
        restartLevelButton.onClick.AddListener(RestartLevel);        
    }
    
    private void InitLevel()
    {
        InitLevelDontRefreshLifes();
        foreach (GameObject life in lifesUI)
        {
            if (!life.activeInHierarchy)
               life.SetActive(true);
        }
    }
    
    private void InitLevelDontRefreshLifes()
    {
        messageText.gameObject.SetActive(false);
        nextLevelButton.gameObject.SetActive(false);
        restartLevelButton.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }
    
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
        messageText.text = "Congratulations. Go to next level!";
        messageText.gameObject.SetActive(true);
        nextLevelButton.gameObject.SetActive(true);
        Time.timeScale = 0f;
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
        lifesUI[vidas].gameObject.SetActive(false);

        if (vidas <= 0)
        {
            // GameOver
            GameOver();
        }
        else
        {
            Debug.Log(vidas);
            // Reiniciar nivel  
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        messageText.text = "You lose!";
        messageText.gameObject.SetActive(true);
        restartLevelButton.gameObject.SetActive(true);
        vidas = 3;
        Time.timeScale = 0f;
        // Cargar Escena GameOver
    }

    public void WinGame()
    {
        Debug.Log("You Win!");
        Time.timeScale = 0f;
    }


    private void NextLevel()
    {
        if (level == 1)
        {
            level = 2;
            SceneManager.LoadScene("Level 2");
            InitLevelDontRefreshLifes();            
        }
        // else if (level == 2)
        //     SceneManager.LoadScene("Level 3");
    }
    
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        InitLevel();
    }
}
