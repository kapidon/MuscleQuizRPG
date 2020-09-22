using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using DG.Tweening;

public class QuestManager : MonoBehaviour
{
    public Text questClearText;
    public GameObject questClear;
    public QuizMgr quizMgr;
    public int stageNumber = 0;
    public int maxStageNumber = 5;
    public GameObject[] enemyObjects;
    public QuestUIMgr questUIMgr;
    public GameObject questClearImage;
    public GameObject gameOverText;
    public QuestUIMgr qUI;
    public GameObject questBG;



    public void OnClickNextButton()
    {
        SoundMgr.instance.PlaySE(0);
        questUIMgr.HideButton();
        StartCoroutine(Seaching());

    }
    IEnumerator Seaching()
    {
        questBG.transform.DOScale(new Vector3(1.8f, 1.8f, 1.8f),1.5f)
            .OnComplete(() => questBG.transform.localScale = new Vector3(1, 1, 1));
        SpriteRenderer questBGSR = questBG.GetComponent<SpriteRenderer>();
        questBGSR.DOFade(0, 2f)
            .OnComplete(() => questBGSR.DOFade(1, 0));
        if (stageNumber < maxStageNumber)
        {
            yield return new WaitForSeconds(2f);
            SoundMgr.instance.PlayBGM("Quiz");
            EncountEnemy();
            yield return new WaitForSeconds(2f);
            questUIMgr.ShowQuizButton();
            quizMgr.QuizSet();
            quizMgr.AnswerSet();
        }
        else
        {
           StartCoroutine(QuestClear());
        }
    }

    // Update is called once per frame

    public void EncountEnemy()
    { 
        int enemyObj = Random.Range(0, enemyObjects.Length);
        Instantiate(enemyObjects[enemyObj]);
        StartCoroutine(qUI.ShowAndEEButton()) ;

    }
    public IEnumerator QuestClear()
    {
        yield return new WaitForSeconds(2f);
        SoundMgr.instance.StopBGM();
        SoundMgr.instance.PlaySE(5);
        questUIMgr.HideButton();
        Debug.Log("クエストクリア");
        questClear.SetActive(true);
        questClearText.text = "クエストクリア";
        questClearImage.SetActive(true);
        questUIMgr.ShowTitleButton();
    }
    public void GameOver()
    {
        SoundMgr.instance.StopBGM();
        SoundMgr.instance.PlaySE(6);
        questUIMgr.HideQuizButtons();
        questUIMgr.HideButton();
        gameOverText.SetActive(true);
        questUIMgr.ShowTitleButton();
    }
    public void OnToTitleButton()
    {
        SoundMgr.instance.PlaySE(0);
    }
}
