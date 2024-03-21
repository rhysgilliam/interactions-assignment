using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInteract : MonoBehaviour, IInteractable
{
    public GameObject fire;

    public void Interact()
    {
        fire.SetActive(!fire.activeSelf);
    }
}
