using UnityEngine;

public class fakeHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {

            this.GetComponent<Collider>().enabled = true;
        }
        else
        {
            this.GetComponent<Collider>().enabled = false;
        }
    }
}
