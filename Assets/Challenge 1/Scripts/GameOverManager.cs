using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private TextMeshProUGUI messageText;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        // FindObjectOfType<Canvas>();  NO
        Destroy(canvas); // Mejor deshabilitarlo pq GameManager tiene referencias.
        GameObject eventSystem = GameObject.Find("EventSystem");
        Destroy(eventSystem);
        
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager.GetWinGame())
        {
            messageText.text = "Congratulations. You mastered it!";
        }
        else
        {
            messageText.text = "Sorry. Try again later!";
        }
    }

    
}
