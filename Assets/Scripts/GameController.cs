using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    private void Awake()
    {
        controller = this;
    }

    [Header("获得宝箱数量")]
    public int dieChestCount;

    [Header("总共存在的宝箱总数")]
    public int number;

    public void SetMaxChestCount(int number)
    {
        this.number = number;
    }
    /// <summary>
    /// 怪物数量控制
    /// </summary>
    public void AddDieChestCount()
    {
        dieChestCount++;
        UIController.contronller.SetDieChestCount(dieChestCount);
        if (dieChestCount == number)
        {
            UIController.contronller.ShowResultPanel();
            //游戏结束
            Debug.Log("游戏结束");
        }
    }
   

    // Start is called before the first frame update
    void Start()
    {
        UIController.contronller.SetChestCount(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
