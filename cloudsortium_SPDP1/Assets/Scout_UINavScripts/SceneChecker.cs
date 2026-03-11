using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChecker : MonoBehaviour
{
    void Update()
    {
        GameObject childObject = transform.Find("HQ_ButtonManager").gameObject;

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (childObject != null)
            {
                childObject.SetActive(true);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            if (childObject != null)
            {
                childObject.SetActive(false);
            }
        }
    }
}
