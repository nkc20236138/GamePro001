using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class kyori : MonoBehaviour
{
    Text textConponent;
   public int meitoru= 0;
    public GameObject bossmob;
    
    
    void Start()
    {
        textConponent = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        textConponent.text = meitoru.ToString("0000000") +" km";
        meitoru++;
       
    }
   
}
