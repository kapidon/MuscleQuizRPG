using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransitionManager : MonoBehaviour
{
    public void LoadTo(string sceneName)
    {
        FadeInOutMgr.instance.FadeOutToIn(() => Load(sceneName));
    }
    public void Load(string sceneName)
    {
        SoundMgr.instance.PlayBGM(sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
