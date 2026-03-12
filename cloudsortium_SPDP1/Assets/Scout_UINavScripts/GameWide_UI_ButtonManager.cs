using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameWide_UI_ButtonManager : MonoBehaviour
{
    public static GameWide_UI_ButtonManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartReturn()
    {
        SceneManager.LoadScene(0);
    }

    public void StartPlatformer()
    {
        SceneManager.LoadScene(2);
    }

    public void ReturnHQ()
    {
        SceneManager.LoadScene(1);
    }
}
