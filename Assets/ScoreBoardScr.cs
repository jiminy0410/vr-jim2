using TMPro;
using UnityEngine;

public class ScoreBoardScr : MonoBehaviour
{
    public float Score;
    public bool gameStart;
    public GameObject ScoreText1;
    public GameObject ScoreText2;
    public GameObject ScoreText3;
    public GameObject ScoreText4;
    public GameObject ScoreText5;
    public float startTime = 0.0f;

    private void Start()
    {
        Score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            startTime += Time.deltaTime;
            ScoreText5.GetComponent<TextMeshPro>().text = "Score:" + Score.ToString();
        }
    }

    public void timerEnded(int gameMode)
    {
        switch (gameMode)
        {
            case 1:
                ScoreText1.GetComponent<TextMeshPro>().text = "2D Color time: " + startTime.ToString();
                break;
            case 2:
                ScoreText2.GetComponent<TextMeshPro>().text = "3D Color time: " + startTime.ToString();
                break;
            case 3:
                ScoreText3.GetComponent<TextMeshPro>().text = "2D Picture time: " + startTime.ToString();
                break;
            case 4:
                ScoreText4.GetComponent<TextMeshPro>().text = "2D Picture time: " + startTime.ToString();
                break;
        }
        startTime = 0.0f;
    }
}
