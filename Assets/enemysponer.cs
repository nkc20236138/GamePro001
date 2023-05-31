using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysponer : MonoBehaviour
{
    GameObject Player;
    public GameObject Fire;
    public GameObject enemy;
    public GameObject bossmob;
    public GameObject kyori;
    GameObject spone;
    float span = 30f;
    float delta = 0f; 
   int syuuki = 0;
    int reberu  = 0;
    GameObject spon;
    int recyasuto = 5;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("MyChar_0 (1)");
        kyori = GameObject.Find("kyori");
    }

    // Update is called once per frame
    void Update()
    {
        kyori.GetComponent<kyori>();
        if(Input.GetKeyDown(KeyCode.F) && recyasuto >= 10)
        {
            //Debug.Log("gg");
            GameObject spon= Instantiate(Fire);
            spon.transform.position =  Player.transform.position + new Vector3(1, 0, 0);
        }
        if (span > 10) 
        span = 30 - reberu;
        recyasuto++;
        delta++;
        syuuki++;
        if (delta  > span)
        {
            delta = 0f;
            int ransuu = Random.Range(-4, 5);

            GameObject spone = Instantiate(enemy);
            spone.transform.position = new Vector3(9,ransuu,0);
        }
        if (syuuki == 600)
        {
            spone = Instantiate(bossmob);
            spone.transform.position = new Vector3(9, 0, 0);
            reberu++;
            syuuki = 0;
        }
    }
}
