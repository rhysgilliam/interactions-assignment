using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OnEnterClick()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
