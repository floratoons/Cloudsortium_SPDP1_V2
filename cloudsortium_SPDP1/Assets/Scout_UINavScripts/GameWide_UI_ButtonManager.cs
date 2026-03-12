using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameWide_UI_ButtonManager : MonoBehaviour
{
    public static GameWide_UI_ButtonManager Instance;
    public AudioSource bgMusic;

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

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Debug.Log("Platformer scene (for music manager)");
            bgMusic.Stop();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            bgMusic.PlayDelayed(2.0f);
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
