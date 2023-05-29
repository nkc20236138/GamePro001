using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    int kaunnter = 0;
    int sa ;
    int bo = 0;
    Vector2 sad =  Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        int sa = 0;
      
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
    public void curiticaru() 
    {

        transform.Translate(1,0,0);
        Debug.Log("boss");
        if (kaunnter == 3)
        {
            Destroy(gameObject);
            kaunnter = 0;
            
        }
        kaunnter++;
    }

    private void OnTriggerEnter(Collider other)
    {
        kaunnter++;
        transform.Translate(1, 0, 0);
        Debug.Log("boss");
        if (kaunnter == 3)
        {
            transform.position = Vector2.zero;
            if (kaunnter == 5)
            {
                Destroy(gameObject);
                kaunnter = 0;

            }
        }
        kaunnter++;
    }
}
