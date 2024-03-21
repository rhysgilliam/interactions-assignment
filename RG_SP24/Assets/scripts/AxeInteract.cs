using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInteract : MonoBehaviour, IInteractable
{
    public GameObject blood;
    public void Interact()
    {
        blood.SetActive(false);
    }
}
