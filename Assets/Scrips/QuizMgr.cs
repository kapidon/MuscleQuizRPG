using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class QuizMgr : MonoBehaviour
{
    
    public Text quizSet;
    public int k = 0;
    public void QuizSet()
    {
            int n = UnityEngine.Random.Range(0, StageSelects.instance.randomNumbers.Count);
            k = StageSelects.instance.randomNumbers[n];
            Debug.Log(StageSelects.instance.csvs[k][0]);
            Debug.Log(k);
            for (int o = 0; o < StageSelects.instance.randomNumbers.Count; o++)
            {
                Debug.Log(StageSelects.instance.randomNumbers[o]);
            }
            quizSet.text = StageSelects.instance.csvs[k][0];
        StageSelects.instance.randomNumbers.Remove(k);
        
    }
    public void AnswerSet()
    {
        string[] array = new string[] {StageSelects.instance.csvs[k][1], StageSelects.instance.csvs[k][2], StageSelects.instance.csvs[k][3] };
        array = array.OrderBy(x => System.Guid.NewGuid()).ToArray();

        for (int i=1; i<=3; i++)
        {
            Text ansSentence = GameObject.Find("Quiz/AnswerButton" + i).GetComponentInChildren<Text>();
           ansSentence.text = array[i-1];
        }
    }

}
