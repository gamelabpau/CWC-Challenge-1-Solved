using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(LoadLevel1);
    }

    private void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
