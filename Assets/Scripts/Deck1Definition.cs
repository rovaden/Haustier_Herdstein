using UnityEngine;
using System;

public class Deck1Definition : MonoBehaviour
{
    // defining this gameObject allows us to acces the scripts we need
    public GameObject cards;
    CardData cardData;
    CardList cardList;

    public string[] deck1;

    // defines the contents of deck1 with an array of names only
    public void setDeck1() {
        cardData = cards.GetComponent<CardData>();
        cardList = cards.GetComponent<CardList>();
        Array.Resize(ref deck1, 25);
        deck1[0] = cardData.cardNameList[30];
        deck1[1] = cardData.cardNameList[44];
        deck1[2] = cardData.cardNameList[27];
        deck1[3] = cardData.cardNameList[27];
        deck1[4] = cardData.cardNameList[28];
        deck1[5] = cardData.cardNameList[28];
        deck1[6] = cardData.cardNameList[9];
        deck1[7] = cardData.cardNameList[9];
        deck1[8] = cardData.cardNameList[30];
        deck1[9] = cardData.cardNameList[7];
        
        deck1[10] = cardData.cardNameList[7];
        deck1[11] = cardData.cardNameList[3];
        deck1[12] = cardData.cardNameList[3];
        deck1[13] = cardData.cardNameList[23];
        deck1[14] = cardData.cardNameList[23];
        deck1[15] = cardData.cardNameList[22];
        deck1[16] = cardData.cardNameList[22];
        deck1[17] = cardData.cardNameList[4];
        deck1[18] = cardData.cardNameList[4];
        deck1[19] = cardData.cardNameList[42];

        deck1[20] = cardData.cardNameList[42];
        deck1[21] = cardData.cardNameList[25];
        deck1[22] = cardData.cardNameList[25];
        deck1[23] = cardData.cardNameList[20];
        deck1[24] = cardData.cardNameList[15];
    }

    //returns the name of the card if given the index in deck1
    public string getDeck1(int index) {
        if (deck1 != null) return deck1[index];
        else return null;
    }


}
