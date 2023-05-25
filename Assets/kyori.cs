using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class kyori : MonoBehaviour
{
    Text textConponent;
    int meitoru= 0000;
    // Start is called before the first frame update
    void Start()
    {
        textConponent = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        textConponent.text = meitoru +" km";
        meitoru++;
    }
}
