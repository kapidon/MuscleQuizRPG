﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FadeInOutMgr : MonoBehaviour
{
    public static FadeInOutMgr instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public CanvasGroup canvasGroup;

    
    public void FadeOut()
    {
        canvasGroup.blocksRaycasts = true;
        
        canvasGroup.DOFade(1,2f)
            .OnComplete(() => canvasGroup.blocksRaycasts = false);
    }
    public void FadeIn()
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.DOFade(0,2f)
            .OnComplete(() => canvasGroup.blocksRaycasts = false);
    }
    public void FadeOutToIn(TweenCallback action)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.DOFade(1, 1f)
            .OnComplete(() => {
                action();
                FadeIn();
                });
    }
}
