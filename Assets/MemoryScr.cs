using System.Collections.Generic;
using UnityEngine;

public class MemoryScr : MonoBehaviour
{
    public List<GameObject> Pairs = new List<GameObject>();
    public List<GameObject> Cubes = new List<GameObject>();
    public List<Vector3> positions = new List<Vector3>();
    public int changed;

    public List<Vector3> toShuffle = new List<Vector3>();

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

        if (changed >= 2)
        {
            foreach (GameObject p in Pairs)
            {
                p.GetComponent<PairScr>().revertCoulour();
                changed = 0;
            }
        }
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
