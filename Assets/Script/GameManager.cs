using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGameEnded = false;
    public float delay = 3f;
    public GameObject completeGameUI;

    public void setIsGameEnded(bool value)
    {
        isGameEnded = value;
    }

    public void LevelComplete(bool value)
    {
        if (value)
        {
            completeGameUI.SetActive(value);
            FindObjectOfType<GameManager>().enabled = false;
        }
    }

    public void EndGame()
    {
        if (isGameEnded)
        {
            isGameEnded = false;
            Invoke("Restart", delay);
        }  
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
