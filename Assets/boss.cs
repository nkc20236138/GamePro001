using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    int kaunnter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-0.07f, 0, 0);

        if (transform.position.x < -1)
        {
            transform.Translate(0.07f ,0,0);
        }
    }
    public void damag() 
    {
        
        if (kaunnter == 3)
        {
            transform.Translate(0.07f, 0, 0);
            //Destroy(gameObject);
            kaunnter = 0;
        }
        kaunnter++;
    }
}
