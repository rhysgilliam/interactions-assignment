using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
public class RayCast : MonoBehaviour
{
    public Transform interactionSource;
    public float contactDistance;
    public GameObject interactText;

    // Update is called once per frame
    private void Update()
    {
        var r = new Ray(interactionSource.position, interactionSource.forward);
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Debug.Log("Trying to interact...");
            // Debug.DrawRay(r.origin, r.direction * contactDistance, Color.red, 10f);
            if (Physics.Raycast(r, out var hitInfo, contactDistance))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    // Debug.Log("Found an interactable!");
                    interactObj.Interact();
                }
            }
        }
        // permanent ray for interact text
        interactText.SetActive(Physics.Raycast(r, out var hitInfoText, contactDistance) &&
                               hitInfoText.collider.gameObject.TryGetComponent(out IInteractable interactableObj));
    }
}
