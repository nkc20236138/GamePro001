using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysponer : MonoBehaviour
{
    GameObject Player;
    public GameObject Fire;
    public GameObject enemy;
    public GameObject bossmob;
    GameObject spone;
    float span = 30f;
    float delta = 0f; 
   int syuuki = 0;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("MyChar_0 (1)");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            GameObject spone = Instantiate(Fire);
            spone.transform.position =  Player.transform.position + new Vector3(1, 0, 0);
        }
        

        delta++;
        syuuki++;
        if (delta > span)
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

            syuuki = 0;
        }
    }
}
