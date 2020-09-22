using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestUIMgr : MonoBehaviour
{
    public GameObject nextButton;
    public GameObject[] QButtons;
    public GameObject titleButton;
    public GameObject eeButon;
    

    public void HideButton()
    {
        nextButton.SetActive(false);
    }
    public void ShowButton()
    {
        nextButton.SetActive(true);
    }
    public void ShowQuizButton()
    {
        for (int i = 0; i <= 4; i++)
        {
            QButtons[i].SetActive(true);
        }
    }
    public void HideQuizButtons()
    {
        for(int i = 0; i <= 4; i++)
        {
            QButtons[i].SetActive(false);
        }
    }
    public void ShowTitleButton()
    {
        titleButton.SetActive(true);
    }
    public IEnumerator ShowAndEEButton()
    { Debug.Log("-------");
        eeButon.SetActive(true);
        yield return new WaitForSeconds(2f);
        eeButon.SetActive(false);
        
    }
}
