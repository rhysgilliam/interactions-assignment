using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    private Renderer component;
    private void Start()
    {
        component = gameObject.GetComponent<Renderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            component.material.color = Color.red;
    }
}