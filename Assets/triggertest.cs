using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
          print("enter");
    }

    private void OnTriggerExit(Collider other)
    {
        print("exit");
    }
}
