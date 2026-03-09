using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Temp_SceneChange : MonoBehaviour
{
    public static Temp_SceneChange Instance;

    public 

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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("PlayerPrefs deleted");
            PlayerPrefs.DeleteAll();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Moving to final scene");
            SceneManager.LoadScene(3);
        }
    }
}
