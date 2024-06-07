using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    void Awake() 
    {
        if(Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    // public void GameManagerCheck()
    // {
    //     Debug.Log("GameManager Check");
    // }

    public bool isPaused;
    public void ChangeScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Pause() 
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume() 
    {
        Time.timeScale = 1f;
        isPaused = false; 
    }

}
