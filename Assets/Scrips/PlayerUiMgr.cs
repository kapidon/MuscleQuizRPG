using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUiMgr : MonoBehaviour
{
    public Text hpText;
    // Start is called before the first frame update

    public IEnumerator UpdatePUI(PlayerManager player)
    {
        hpText.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        hpText.text = string.Format("プロテイン: {0}", player.hp);
        yield return new WaitForSeconds(0.5f);
        Color newColor = Color.white;
        hpText.color = newColor;
    }

    
}
