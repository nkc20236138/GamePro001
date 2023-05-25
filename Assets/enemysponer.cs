using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysponer : MonoBehaviour
{

    public GameObject enemy;
    public GameObject bossmob;
    GameObject spone;
    float span = 30f;
    float delta = 0f; 
   int syuuki = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
