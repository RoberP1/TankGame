using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    private bool DualShockController;
    private bool canChange=true;
    [SerializeField] GameObject[] selectors;
    [SerializeField] int activeSelectors;
    [SerializeField] int opLength;
    LevelManager levelManager;


    void Start()
    {
        DualShockController = FindObjectOfType<DetectGamePad>().DualShockController;
        levelManager = FindObjectOfType<LevelManager>();
        for (int i = 0; i < opLength; i++)
        {
            if (selectors[i].activeSelf)
            {
                activeSelectors = i;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool ps4Sumit = (DualShockController && Input.GetButtonDown("Submit"));
        if (ps4Sumit || Input.GetButtonDown("XSubmit"))
        {
            Debug.Log(activeSelectors);
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
        if (!canChange) return;
        if (DualShockController && Input.GetAxis("Arrows") <0)
        {
            NextOp();
        }
        else if (DualShockController && Input.GetAxis("Arrows") > 0)
        {
            PreOp();
        }
        else if (!DualShockController && Input.GetAxis("XArrows") < 0)
        {
            NextOp();
        }
        else if (!DualShockController && Input.GetAxis("XArrows") > 0)
        {
            PreOp();
        }
    }
    public void SetLength(int op)
    {
        opLength = op;
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
        StartCoroutine(ChangeDelay());
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
        StartCoroutine(ChangeDelay());
    }
    IEnumerator ChangeDelay()
    {
        canChange = false;
        yield return new WaitForSeconds(0.5f);
        canChange = true;
    }
}
