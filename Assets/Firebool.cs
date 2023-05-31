using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Firebool : MonoBehaviour
{
    GameObject Player;
    GameObject enemy;
   public GameObject boss;
    int tairyoku;
    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindWithTag("boss");
        Player = GameObject.Find("MyChar_0 (1)");
        enemy = GameObject.Find("Timer");
        int tairyoku = 0;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(0.1f, 0, 0);

       
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        
            Debug.Log("hb");

        if (collision.gameObject.tag == "boss")
        {
            Debug.Log("km");
            boss.gameObject.GetComponent<boss>().damage();
        }

        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("aw");
            enemy.GetComponent<timer>().hirl();
            Player.GetComponent<PlayerCont>().kiru();
        }

        Destroy(gameObject);
    }

}
