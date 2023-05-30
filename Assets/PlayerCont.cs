using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCont : MonoBehaviour
{
    private Animator anim;
    float z = 0;
    int time = 6000;
    Vector2 vector2 = Vector2.zero;
    Rigidbody2D rigit2D;
    GameObject timer;
    GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        rigit2D = GetComponent<Rigidbody2D>();
       Application.targetFrameRate = 60;
        anim = gameObject.GetComponent<Animator>();
        timer = GameObject.Find("Timer");
        boss = GameObject.Find("bossmob");
    }

    // Update is called once per frame
    void Update()
    {
        vector2.y = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical") ;
        vector2.x = z * -1;


        if (vector2.x == -1)
        {

            anim.SetBool("Right", true);
        }
        else
        {
            anim.SetBool("Right", false);
        }

        if (vector2.x == 1)
        {
            //Bool型のパラメーターであるblRotをTrueにする
            anim.SetBool("Light", true);
        }
        else
        {
            anim.SetBool("Light", false);
        }
        this.rigit2D.transform.Translate(vector2.normalized / 15);
         vector2 = vector2 * 0;

        if (time < 0)
        {
            SceneManager.LoadScene("titleScene");
        }
        time--;

    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        //timer.GetComponent<timer>().damage();
        GameObject timer = GameObject.Find("Timer");
        GameObject boss = GameObject.Find("bossmob");
        timer.GetComponent<timer>().damage();
        if (other.gameObject.tag == "boss")
        {
            timer.GetComponent<timer>().damage();
           // boss.GetComponent<boss>().bosshit();
        }

    }
}
