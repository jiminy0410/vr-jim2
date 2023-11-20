using System.Collections.Generic;
using UnityEngine;

public class MemoryScr : MonoBehaviour
{
    public List<GameObject> Pairs = new List<GameObject>();
    public List<GameObject> Cubes = new List<GameObject>();
    public List<Vector3> positions = new List<Vector3>();
    public int changed;

    public List<Vector3> toShuffle = new List<Vector3>();
    [SerializeField] GameObject GM;
    public float targetTime = 0.5f;



    public void Start()
    {
        foreach (GameObject p in Pairs)
        {
            p.GetComponent<PairScr>().revertCoulour();
            changed = 0;
        }

        foreach (GameObject c in Cubes)
        {
            toShuffle.Add(c.transform.position);
            c.transform.position = new Vector3(10, 10, 10);
        }

        ShuffleList(toShuffle);

        for (int i = 0; i < Cubes.Count; i++)
        {
            Cubes[i].transform.position = positions[i];
        }

    }
    public void Update()
    {

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

        if (changed >= 2)
        {
            targetTime -= Time.deltaTime;
        }
        else
        {
            targetTime = 0.5f;
        }

        if (changed > 0)
        {
            GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().gameStart = true;
        }

        if (GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().Score % Pairs.Count == 0 && GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().Score > 1)
        {
            GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().timerEnded(GM.GetComponent<gameMan>().currentGame);
            finish();
            GM.GetComponent<gameMan>().currentGame++;
        }
    }

    void timerEnded()
    {
        foreach (GameObject p in Pairs)
        {
            p.GetComponent<PairScr>().revertCoulour();
            changed = 0;
        }
    }

    public void finish()
    {
        GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().gameStart = false;
        GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().startTime = 0;
        foreach (GameObject p in Pairs)
        {
            p.GetComponent<PairScr>().correct = 0;
            p.GetComponent<PairScr>().revertCoulour();
            changed = 0;
        }

        foreach (GameObject c in Cubes)
        {
            toShuffle.Add(c.transform.position);
            c.transform.position = new Vector3(10, 10, 10);
        }

        ShuffleList(toShuffle);

        for (int i = 0; i < Cubes.Count; i++)
        {
            Cubes[i].transform.position = positions[i];
        }
        GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().Score = 0;
    }

    public void ShuffleList(List<Vector3> list)
    {
        List<Vector3> temp = new List<Vector3>();
        temp.AddRange(list);

        for (int i = 0; i < list.Count; i++)
        {
            int index = Random.Range(0, temp.Count - 1);
            positions.Add(temp[index]);
            temp.RemoveAt(index);
        }
    }
}
