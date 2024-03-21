using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapestryInteract : MonoBehaviour, IInteractable
{
    private bool moving;
    private bool moved;
    public float speed;
    public float limit;
    // Start is called before the first frame update
    private void Start()
    {
        moving = false;
        moved = false;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (moving)
        {
            transform.position = new Vector3(transform.position.x, 
                transform.position.y, 
                transform.position.z - speed);

            if (transform.position.z < limit)
            {
                moving = false;
                moved = true;
            }
        }
    }

    public void Interact()
    {
        if (!moved)
        {
            moving = true;
        }
    }
}
