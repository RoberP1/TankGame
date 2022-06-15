using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public UnityEvent OnFinish;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Win();
        }
    }
    public void Finish()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length == 0)
        OnFinish?.Invoke();
    }
    public void Win()
    {
        OnFinish?.Invoke();
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }  
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void SinglePlayer()
    {
        SceneManager.LoadScene(1);
    }
    public void MultyPlayer()
    {
        SceneManager.LoadScene(2);
    }
}
