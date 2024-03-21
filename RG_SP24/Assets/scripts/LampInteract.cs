using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampInteract : MonoBehaviour, IInteractable
{
    public GameObject lightObj;

    public void Interact()
    {
        lightObj.SetActive(!lightObj.activeSelf);
    }
}
