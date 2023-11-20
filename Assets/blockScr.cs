using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockScr : MonoBehaviour
{
    [SerializeField] GameObject Pair;
    PairScr parScr;
    // Start is called before the first frame update
    void Start()
    {
        parScr = Pair.GetComponent<PairScr>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "grab")
        {
            if (this.name == "Cube 1")
            {
                if (!parScr.Cube1Done)
                {
                    //Debug.Log("col");
                    parScr.Cube1Done = true;
                    parScr.memoryScr.changed++;
                    parScr.correct++;
                    parScr.checkCoulour();
                    parScr.done();
                    parScr.changeCoulour(parScr.Coulour, this.gameObject);
                }
            }
            else if (this.name == "Cube 2")
            {
                if (!parScr.Cube2Done)
                {
                    //Debug.Log("col2");
                    parScr.Cube2Done = true;
                    parScr.memoryScr.changed++;
                    parScr.correct++;
                    parScr.checkCoulour();
                    parScr.done();
                    parScr.changeCoulour(parScr.Coulour, this.gameObject);
                }
            }
        }
        //Debug.Log("ik ben " + this.gameObject.name);
    }
}
