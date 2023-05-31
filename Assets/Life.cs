using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    float mottainai = 100;
    GameObject Lif;
    float inoti ;
    // Start is called before the first frame update
    void Start()
    {
        Lif = GameObject.Find("Life");
        inoti = mottainai / 100;


    }

    // Update is called once per frame
    void Update()
    {
        inoti = mottainai / 100;
        Lif.GetComponent<Image>().fillAmount = inoti;


    }

    //ì≈ÇÃêSëü
    public void dokurinngo()
    {
        mottainai -= 1;
    }

    //êVëNÇ»êSëü
    public void sinnzou()
    {
        mottainai += 5;
    }
}
