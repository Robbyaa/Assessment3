using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform finish91;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        
        ScoreText.text = finish91.position.x.ToString("0");
    }
}
