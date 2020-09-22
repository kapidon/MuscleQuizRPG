using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Judge : MonoBehaviour

{
    public Transform cameraObj;
    public PlayerManager player;
    public QuestManager questManager;
    public QuizMgr quiz;
    public QuestUIMgr qUI;
    public PlayerUiMgr pUI;
    public GameObject maru;
    public GameObject batu;
    public Button[] ansButonns;
    public GameObject hitEffect;
    public void OnClickAnswerButtons()
    {
        if(this.enabled == false)
        {
            return;
        }
        else
        {
            for(int i = 0; i < 3; i++)
            {
                ansButonns[i].enabled = false;
            }
            Debug.Log("Clicked");
            StartCoroutine(JudgeAnswer());
        }
    }
    IEnumerator JudgeAnswer()
    {
        Text selectBtn = this.GetComponentInChildren<Text>();
        if (selectBtn.text == StageSelects.instance.csvs[quiz.k][1])
        {
            questManager.stageNumber++;
            Debug.Log("正解");
            GameObject maruObj = Instantiate(maru);
            SoundMgr.instance.PlaySE(1);
            GameObject.Destroy(maruObj, 0.5f);
            yield return new WaitForSeconds(1f);
            SoundMgr.instance.PlaySE(3);
            
            GameObject enemyDamage = GameObject.FindGameObjectWithTag("Enemy");
            Instantiate(hitEffect,enemyDamage.transform,false);
            enemyDamage.transform.DOShakePosition(0.3f,1f,20,0,false,true);
            GameObject.Destroy(enemyDamage,1f);
            yield return new WaitForSeconds(2f);
            for (int i = 0; i < 3; i++)
            {
                ansButonns[i].enabled = true;
                Debug.Log(123);
            }
            qUI.HideQuizButtons();
            qUI.ShowButton();
            SoundMgr.instance.PlayBGM("Quest");
        }
        else
        {
            Debug.Log("不正解");
            GameObject batuObj = Instantiate(batu);
            SoundMgr.instance.PlaySE(2);
            GameObject.Destroy(batuObj, 0.5f);
            yield return new WaitForSeconds(1f);
            SoundMgr.instance.PlaySE(4);
            cameraObj.transform.DOShakePosition(0.3f, 1f, 20, 0, false, true);
            player.Damage();
            StartCoroutine(pUI.UpdatePUI(player));
            yield return new WaitForSeconds(1f);
            if (player.hp == 0)
            {
                questManager.GameOver();
            }
            for (int i = 0; i < 3; i++)
            {
                ansButonns[i].enabled = true;
                Debug.Log(123);
            }
            NotActiveQuiz();
        }
    }
    public void NotActiveQuiz()
    {
        this.gameObject.SetActive(false);
    }
}
