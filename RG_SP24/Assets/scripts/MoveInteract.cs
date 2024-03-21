using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInteract : MonoBehaviour, IInteractable
{
    private bool moving;
    public Transform target;
    public float speed;
    public float rotationSpeed;

    public void Start()
    {
        moving = false;
    }

    public void Update()
    {
        if (moving)
        {
            var targetPosition = target.position;

            transform.position = Vector3.Lerp(transform.position, 
                targetPosition, 
                speed * Time.deltaTime);
            // Rotation
            // Target: Quaternion.identity (0 0 0)
            transform.rotation = Quaternion.Lerp(transform.rotation, 
                Quaternion.identity, 
                rotationSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f &&
                Quaternion.Angle(transform.rotation, Quaternion.identity) < 0.1f)
                moving = false;
        }
    }
    public void Interact()
    {
        moving = true;
    }
    
    
}
