using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardList : MonoBehaviour
{
    public CardData cardData;
    // Start is called before the first frame update
    void Start()
    {
        CardData cardData = gameObject.GetComponent<CardData>();
        cardData.createCard("card one");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
