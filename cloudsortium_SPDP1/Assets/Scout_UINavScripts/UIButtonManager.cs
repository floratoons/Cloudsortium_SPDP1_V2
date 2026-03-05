using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject msgcanvas1;
    public GameObject msgcanvas2;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void StartReturn()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowMsgs1()
    {
        msgcanvas1.SetActive(true);
        msgcanvas2.SetActive(false);
    }
    public void ShowMsgs2()
    {
        msgcanvas1.SetActive(false);
        msgcanvas2.SetActive(true);
    }
}
