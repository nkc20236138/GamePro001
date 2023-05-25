using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    float zikan = 1f;
    float speed = 0;
    GameObject time;
    // Start is called before the first frame update
    void Start()
    {
        this.time = GameObject.Find("timer");
    }

    // Update is called once per frame
    void Update()
    {
        speed++;
        if (speed >= 6)
        {
            zikan -= 0.001f;
            speed = 0;
        }
        this.time.GetComponent<Image>().fillAmount = zikan;
        if (zikan <= 0)
        {
            SceneManager.LoadScene("titleScene");
        }
    }
    public void damage()
    {
       zikan -= 0.1f;
    }
}
