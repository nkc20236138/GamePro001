using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    int kaunnter = 0;
    int bo = 0;
    Vector2 sad =  Vector2.zero;
    GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer");
      
    }

    // Update is called once per frame
    void Update()
    {
        
        if(bo < 30)
        {
            transform.Translate(-0.07f, 0, 0);
        }
        else if(bo < 110)
        {
            transform.Translate(-0.05f, -0.05f, 0);
        }
        else if (bo < 180)
        {
            transform.Translate(-0.05f, 0.05f, 0);
        }
        else if (bo < 260)
        {
            transform.Translate(0.05f, 0.05f, 0);
        }
        else if (bo < 330)
        {
            transform.Translate(0.05f, -0.05f, 0);
        }
        else
        {
            bo = 30;
        }

        //transform.Translate(-0.07f, 0, 0);

        // if (transform.position.x < -1 && sa != 1 )
        //{
        //    transform.Translate(0.07f ,0,0);
        //    int sa = 1;
        //    transform.Rotate(Vector3.forward, 10);


        //}
        //else if (transform.position.y < -2 || bo == 0 )
        //{
        //    transform.Rotate(Vector3.forward, -10);

        //    transform.Translate(-0.07f, 0.1f, 0);
        //    if(transform.position.x < -5)
        //    {
        //        bo++;
        //    }
        //}
        //else if(kaunnter >= 1)
        //{
        //    transform.Translate(0.07f, 0, 0);
        //    transform.position += transform.forward * 1 * Time.deltaTime;
        //}
        bo++;
    }
    //public void bosshit() 
    //{

    //   // transform.Translate(1,0,0);
    //    Debug.Log("boss");
    //    if (kaunnter <= 3)
    //    {
    //        kaunnter = -1;
    //        Destroy(gameObject);
    //        Debug.Log("blake");
    //    }
    //   kaunnter++;
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            Debug.Log("bo");
            
            
               
                if (kaunnter == 3)
                {
            Debug.Log("fgh");
                    Destroy(gameObject);
                   kaunnter = 0;

                }
            
            kaunnter++;
        if(collision.gameObject.tag == "Fire")
        {
            kaunnter++;
        }
        
    }

    public void damage()
    {
        Debug.Log("kf");
        if (kaunnter == 3)
        {
            Debug.Log("fgh");
            Destroy(gameObject);
            kaunnter = 0;
            timer.gameObject.GetComponent<timer>().move();

        }
        kaunnter++;
    }

}
