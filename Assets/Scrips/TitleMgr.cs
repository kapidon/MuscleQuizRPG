using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMgr : MonoBehaviour
{
    public void Awake()
    {
        GameObject csvObj = GameObject.FindGameObjectWithTag("CSV");
        Destroy(csvObj);
    }
    
    
    public void OnToQuestButton()
    {
        SoundMgr.instance.PlaySE(0);
    }
}
