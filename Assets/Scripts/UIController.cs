using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController contronller;

    public void Awake()
    {
        contronller = this;
    }

    [Header("获得的宝箱数量")]
    public Text dieChestText;

    [Header("宝箱总数显示文本")]
    public Text chestCountText;


    public void SetDieChestCount(int dieChestCount)
    {
        dieChestText.text = dieChestCount.ToString();
    }

    public void SetChestCount(int chestCount)
    {
        chestCountText.text = chestCount.ToString();
    }

    #region 游戏结束界面逻辑
    [Header("游戏结束弹出界面")]
    public GameObject resultPanel;


    public void ShowResultPanel()
    {
        resultPanel.SetActive(true);

        
    }

    public void YesBtn()
    {
      
            SceneManager.LoadScene("StartScene");
       
        
    }
    public void Exit()
    {
        
    }
    #endregion
}
