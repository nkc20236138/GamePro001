using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebool : MonoBehaviour
{
    GameObject Player;
    GameObject enemy;
   public GameObject boss;
    int tairyoku = 0;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("MyChar_0 (1)");
        enemy = GameObject.Find("Timer");
        boss = GameObject.Find("bossmob");

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(0.1f, 0, 0);

       
        if (transform.position.x > 100)
        {
            Destroy(gameObject);

        }
    }

     void OnTriggerEnter(Collider other)
    {
        Debug.Log("hb");
    
        if(other.gameObject.tag == "boss")
        {
            Debug.Log("km");
            boss.GetComponent<boss>().curiticaru();
            enemy.GetComponent<timer>().move();
        }
        else 
        {
           Destroy(enemy);
        }
    }
}
