using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LevelManager : MonoBehaviour
{
    public UnityEvent OnFinish;
    public UnityEvent OnPause;
    public UnityEvent OnUnPause;
    private bool DualShockController;

    private void Start()
    {
        DualShockController = GetComponent<DetectGamePad>().DualShockController;
    }
    private void Update()
    {
        bool ps4 = (DualShockController && Input.GetButtonDown("Pause"));
        bool Xcon = (!DualShockController && Input.GetButtonDown("Pause"));
        if ( ps4|| Xcon)
        {
            Pause();
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
    public void Pause()
    {
        OnPause?.Invoke();
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
        OnUnPause?.Invoke();
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
