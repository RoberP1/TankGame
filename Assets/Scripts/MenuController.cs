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
    public bool CanChange;



    void Start()
    {
        CanChange = true;
        levelManager = FindObjectOfType<LevelManager>();
        for (int i = 0; i < opLength; i++)
        {
            if (selectors[i].activeSelf)
            {
                activeSelectors = i;
            }
        }
    }
    public void pause()
    {
        CanChange = true;

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
        
        if (ctx.ReadValue<float>() == 1) NextOp();
        else if(ctx.ReadValue<float>() == -1) PreOp();
    }
    public void NextOp()
    {
        Debug.Log("next");
        if (!levelManager.pause || !CanChange) return;
        
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
        StartCoroutine(ChangeDelay());
    }  
    public void PreOp()
    {
        if (!levelManager.pause || !CanChange) return;
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
        StartCoroutine(ChangeDelay());
    }
    public void Sumit()
    {
        OnSelect?.Invoke();
    }
    IEnumerator ChangeDelay()
    {
        CanChange = false;
        yield return new WaitForSeconds(0.5f);
        CanChange = true;
    }


}
