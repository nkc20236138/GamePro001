using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ememycontrollor : MonoBehaviour
{
    float up = -0.05f;
    GameObject speed;

    // Start is called before the first frame update
    void Start()
    {
         speed = GameObject.Find("timer");
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(up, 0, 0);

        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            up -= 0.01f;
            Destroy(gameObject);
            Debug.Log("oo");
        }
        Destroy(gameObject);
    }
}
