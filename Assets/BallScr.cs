using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScr : MonoBehaviour
{
    public Vector3 returnPos;
    public bool hit;
    public float resettimer = 4;
    private float resetFrames;

    // Start is called before the first frame update
    void Start()
    {
        returnPos = this.transform.position;
        resetFrames = resettimer * 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y <= 0)
        {
            Return();
        }
    }
    private void FixedUpdate()
    {
        if (hit)
        {
            resetFrames--;
            if (resetFrames < 0)
            {
                Return();
            }
        }
    }

    public void Return()
    {
        this.transform.position = returnPos;
        hit = false;
        resetFrames = resettimer * 60;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish") == true)
        {
            GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().Score++;
            hit = true;
        }
    }
}
