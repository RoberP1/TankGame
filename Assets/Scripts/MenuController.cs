using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject[] selectors;
    [SerializeField] int activeSelectors;
    [SerializeField] int opLength;
    LevelManager levelManager;
    public UnityEvent OnSelect;


    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        for (int i = 0; i < opLength; i++)
        {
            if (selectors[i].activeSelf)
            {
                activeSelectors = i;
            }
        }
    }


    public void ActionOnClickInGame()
    {
        switch (activeSelectors)
        {
            case 0:
                levelManager.Retry();
                break;
            case 1:
                levelManager.MainMenu();
                break;
            default:
                levelManager.Resume();
                break;
        }
    }  
    public void ActionOnClickMenu()
    {
        switch (activeSelectors)
        {
            case 0:
                levelManager.SinglePlayer();
                break;
            case 1:
                levelManager.MultyPlayer();
                break;
            default:
                levelManager.Resume();
                break;
        }
    }

    public void SetLength(int op)
    {
        opLength = op;
    }
    public void ChangeOp(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() > 0) NextOp();
        else if(ctx.ReadValue<float>() < 0) PreOp();
    }
    public void NextOp()
    {
        if (activeSelectors + 1 >= opLength)
        {
            selectors[activeSelectors].SetActive(false);
            activeSelectors = 0;
            selectors[activeSelectors].SetActive(true);
        }
        else
        {
            selectors[activeSelectors].SetActive(false);
            activeSelectors++;
            selectors[activeSelectors].SetActive(true);
        }
    }  
    public void PreOp()
    {
        if (activeSelectors - 1 < 0)
        {
            selectors[activeSelectors].SetActive(false);
            activeSelectors = opLength-1;
            selectors[activeSelectors].SetActive(true);
        }
        else
        {
            selectors[activeSelectors].SetActive(false);
            activeSelectors--;
            selectors[activeSelectors].SetActive(true);
        }
    }
    public void Sumit()
    {
        OnSelect?.Invoke();
    }


}
