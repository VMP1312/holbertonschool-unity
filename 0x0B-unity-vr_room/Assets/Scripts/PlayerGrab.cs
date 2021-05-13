using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject pick;
    public GameObject myHand;
    private Rigidbody rb;

    bool inHand = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(!inHand)
            {
                pick.transform.SetParent(myHand.transform);
                pick.transform.localPosition = new Vector3(-0.03f, -0.1f, 0.4f);
                rb.useGravity = false;
                inHand = true;
            }
            else
            {
                this.GetComponent<PlayerGrab>().enabled = false;
                pick.transform.SetParent(null);
                rb.useGravity = true;
                inHand = false;
            }
        }
    }
}
