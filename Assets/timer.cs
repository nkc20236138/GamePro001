using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float zikan = 1f;
    float speed = 0;
    GameObject time;
    // Start is called before the first frame update
    void Start()
    {
        this.time = GameObject.Find("Timer");
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
        if (zikan >= 1) { zikan = 0.9999f; }
    }
    public void damage()
    {
        //Debug.Log("sd" + zikan);
        zikan -= 0.1f;
    }
    public void move()
    {
        zikan += 0.3f;
    }
    public void hirl()
    {
        zikan += 0.005f;
    }
}
