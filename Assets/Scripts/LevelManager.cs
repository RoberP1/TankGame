using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LevelManager : MonoBehaviour
{
    public UnityEvent OnStart;
    public UnityEvent OnFinish;
    public UnityEvent OnPause;
    public UnityEvent OnUnPause;
    public bool pause;

    private void Start()
    {
        OnStart?.Invoke();
    }
    private void Update()
    {

            //Pause();

    }
    public void Finish()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length == 0)
        OnFinish?.Invoke();
        pause = true;
    }
    public void Win()
    {
        OnFinish?.Invoke();
    } 
    public void Pause()
    {
        if (pause) return;
        FindObjectOfType<PlayerInput>().pause = true;
        OnPause?.Invoke();
        pause = true;
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }  
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    internal void Resume()
    {
        FindObjectOfType<PlayerInput>().pause = false;
        OnUnPause?.Invoke();

        pause = false;
    }

    public void SinglePlayer()
    {
        SceneManager.LoadScene(1);
    }
    public void MultyPlayer()
    {
        Debug.Log("Loading");
        SceneManager.LoadScene(2);
    }
}
