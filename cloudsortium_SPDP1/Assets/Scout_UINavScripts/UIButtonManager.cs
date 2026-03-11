using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_ButtonManager : MonoBehaviour
{
    public GameObject msgcanvas1;
    public GameObject msgcanvas2;
    public bool finishedGame = false;
    //public GameObject TAB1_;
    //public GameObject TAB1_GameEnd;

    private void Start()
    {
        GameObject msgcanvas1 = GameObject.Find("Panel3_Chat1");
        GameObject msgcanvas2 = GameObject.Find("Panel3_Chat2");

        /*if (!finishedGame)
        {
            TAB1_.SetActive(true);
            TAB1_GameEnd.SetActive(false);
        }
        else if (finishedGame == true)
        {
            TAB1_.SetActive(false);
            TAB1_GameEnd.SetActive(true);
        }*/
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

    public void ReturnStartScreen()
    {
        SceneManager.LoadScene(0);
    }
}
