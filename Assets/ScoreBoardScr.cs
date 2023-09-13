using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoardScr : MonoBehaviour
{
    public float Score;
    public GameObject ScoreText;

    private void Start()
    {
        Score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.GetComponent<TextMeshPro>().text = "Score:" + Score.ToString();
    }
}
