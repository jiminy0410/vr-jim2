using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animateHand : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty grabAnimationAction;
    public Animator handYmator;
    [SerializeField] GameObject grabOb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handYmator.SetFloat("Trigger", triggerValue);

        float gribValue = grabAnimationAction.action.ReadValue<float>();
        handYmator.SetFloat("Grip", gribValue);

        if (gribValue == 1)
        {
            grabOb.GetComponent<Collider>().enabled = true;
        }
        else
        {
            grabOb.GetComponent<Collider>().enabled = false;
        }
    }
}
