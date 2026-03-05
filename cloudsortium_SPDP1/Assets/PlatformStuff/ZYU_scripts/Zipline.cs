using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Zipline : MonoBehaviour
{
    public Transform ziplineStart;
    public Transform ziplineEnd;
    public TextMeshProUGUI ziplineText;

    public float speed = 4.2f;

    private bool isZipping = false;
    private float t = 0;

    private bool canZip = false;



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && !isZipping && canZip)
        {
            isZipping = true;
            t = 0;
        }


        if (isZipping)
        {
            t += Time.deltaTime * speed / Vector2.Distance(ziplineStart.position, ziplineEnd.position);
            transform.position = Vector2.Lerp(ziplineStart.position, ziplineEnd.position, t);


            if (t >= 1f)
            {
                isZipping = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("zip"))
        {
            canZip = true;
            ziplineText.gameObject.SetActive(true);

        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("zip"))
        {
            canZip = false;
            ziplineText.gameObject.SetActive(false);
        }
    }

}