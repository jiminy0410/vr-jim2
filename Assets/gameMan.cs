using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMan : MonoBehaviour
{
    public GameObject game2D;
    public GameObject game3D;
    public int currentGame;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            currentGame++;
            game2D.GetComponent<MemoryScr>().finish();
            game3D.GetComponent<MemoryScr>().finish();
        }

        switch (currentGame)
        {
            case 1:
                game2D.SetActive(true);
                game3D.SetActive(false);
                foreach (GameObject p in game2D.GetComponent<MemoryScr>().Pairs)
                {
                    p.GetComponent<PairScr>().coldog = true;
                }
                foreach (GameObject p in game3D.GetComponent<MemoryScr>().Pairs)
                {
                    p.GetComponent<PairScr>().coldog = true;
                }
                break;
            case 2:
                game2D.SetActive(false);
                game3D.SetActive(true);
                break;
            case 3:
                game2D.SetActive(true);
                game3D.SetActive(false);
                foreach (GameObject p in game2D.GetComponent<MemoryScr>().Pairs)
                {
                    p.GetComponent<PairScr>().coldog = false;
                }
                foreach (GameObject p in game3D.GetComponent<MemoryScr>().Pairs)
                {
                    p.GetComponent<PairScr>().coldog = false;
                }
                break;
            case 4:
                game2D.SetActive(false);
                game3D.SetActive(true);
                break;
            case 5:
                currentGame = 1;
                break;
        }
    }
}
