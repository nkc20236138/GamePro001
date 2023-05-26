using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebool : MonoBehaviour
{
    GameObject enemy;
    GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Timer");
        boss = GameObject.Find("bossmob");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "boss")
        {
            boss.GetComponent<boss>().curiticaru();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
