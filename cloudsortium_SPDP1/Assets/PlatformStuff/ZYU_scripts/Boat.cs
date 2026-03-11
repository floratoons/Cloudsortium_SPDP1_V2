using UnityEngine;

public class Boat : MonoBehaviour
{
    //public float speed;
   // public Transform[] points;
    //private int i;

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            collision.gameObject.transform.SetParent(transform);
        }
    }

    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
    void Start()
    {
      //  transform.position = points[startingPoint].position;
    }

    // Update is called once per frame
    void Update()
    { 
       
       /* if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
             
            i++;
            FlipSprite();
            if (i == points.Length)
            {
                i = 0;
                
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
       */

    }

    /*void FlipSprite()
    {
        { 
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
    */
}
