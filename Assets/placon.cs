using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class placon : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x, y, 0);
 
    }
}
