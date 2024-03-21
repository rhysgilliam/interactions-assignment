using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePhysics : MonoBehaviour
{
    public GameObject controller;
    private Rigidbody rb;

    private void Start()
    {
        rb = controller.GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            rb.isKinematic = true;
            // Debug.Log("pressed k");
        }
        else if (Input.GetKeyDown("j"))
        {
            rb.isKinematic = false;
            // Debug.Log("pressed j");
        }
    }
}
