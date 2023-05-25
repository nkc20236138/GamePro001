using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysponer : MonoBehaviour
{

    public GameObject enemy;
    float span = 30f;
    float delta = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta++;
        if (delta > span)
        {
            delta = 0f;
            int ransuu = Random.Range(-5, 5);
            GameObject spone = Instantiate(enemy);
            spone.transform.position = new Vector3(8,ransuu,0);
        }
    }
}
