using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CardList : MonoBehaviour
{
    public CardData cardData;
    // Start is called before the first frame update
    void Start()
    {
        CardData cardData = gameObject.GetComponent<CardData>();
        cardData.createCard("Haustier Herdstein");
        cardData.setCardDefinition("Haustier Herdstein", 3, 5, 4);
        string definition = cardData.getCardDefinition("Haustier Herdstein");
        Debug.Log(definition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
