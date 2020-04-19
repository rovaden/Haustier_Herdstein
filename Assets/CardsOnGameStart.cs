using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsOnGameStart : MonoBehaviour
{
    public GameObject card;
    public GameObject card2;
    public GameObject card3;
    SpriteRenderer spr1;
    SpriteRenderer spr2;
    SpriteRenderer spr3;
    public GameObject atkTxt1;
    public GameObject atkTxt2;
    public GameObject atkTxt3;
    public GameObject hlthTxt1;
    public GameObject hlthTxt2;
    public GameObject hlthTxt3;

    // Start is called before the first frame update
    void Start()
    {
        spr1 = card.GetComponent<SpriteRenderer>();
        spr2 = card2.GetComponent<SpriteRenderer>();
        spr3 = card3.GetComponent<SpriteRenderer>();
        spr1.sprite = null;
        spr2.sprite = null;
        spr3.sprite = null;
        atkTxt1.SetActive(false);
        atkTxt2.SetActive(false);
        atkTxt3.SetActive(false);
        hlthTxt1.SetActive(false);
        hlthTxt2.SetActive(false);
        hlthTxt3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
