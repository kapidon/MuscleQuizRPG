using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StageSelects : MonoBehaviour
{
    public static StageSelects instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private TextAsset csv;
    public List<string[]> csvs = new List<string[]>();
    private int height = 0;
    private int i, j = 0;
    const int size = 4;
    public List<int> randomNumbers = new List<int>();
    public void OnClick1Butoons()
    {
        SoundMgr.instance.PlaySE(0);
        csv = Resources.Load("CSV/QuizForStage1") as TextAsset;
        StringReader reader = new StringReader(csv.text);
        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            csvs.Add(line.Split(','));
            Debug.Log("reading" + height);
            height++;
        }
        for (i = 0; i < height; i++)
        {
            for (j = 0; j < size; j++)
            {
                Debug.Log("csvs[" + i + "][" + j + "]:" + csvs[i][j]);
            }
        }

        for (int m = 0; m < 15; m++)
        {
            
            randomNumbers.Add(m);
            Debug.Log(m);
        }
    }
    public void OnClick2Butoons()
    {
        SoundMgr.instance.PlaySE(0);
        csv = Resources.Load("CSV/QuizForStage2") as TextAsset;
        StringReader reader = new StringReader(csv.text);
        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            csvs.Add(line.Split(','));
            Debug.Log("reading" + height);
            height++;
        }
        for (i = 0; i < height; i++)
        {
            for (j = 0; j < size; j++)
            {
                Debug.Log("csvs[" + i + "][" + j + "]:" + csvs[i][j]);
            }
        }

        for (int m = 0; m < 15; m++)
        {

            randomNumbers.Add(m);
            Debug.Log(m);
        }
    }
    public void OnClick3Butoons()
    {
        SoundMgr.instance.PlaySE(0);
        csv = Resources.Load("CSV/QuizForStage3") as TextAsset;
        StringReader reader = new StringReader(csv.text);
        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            csvs.Add(line.Split(','));
            Debug.Log("reading" + height);
            height++;
        }
        for (i = 0; i < height; i++)
        {
            for (j = 0; j < size; j++)
            {
                Debug.Log("csvs[" + i + "][" + j + "]:" + csvs[i][j]);
            }
        }

        for (int m = 0; m < 15; m++)
        {

            randomNumbers.Add(m);
            Debug.Log(m);
        }
    }
}
