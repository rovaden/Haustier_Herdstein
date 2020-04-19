using UnityEngine;
using Array = System.Array;

public class DeckHandler : MonoBehaviour
{
    //access the CardData script
    public GameObject cards;
    CardData cardData;
    //access the Deck1Definition script
    public GameObject playerDeck;
    Deck1Definition deck1Definition;
    //creates the hand[] cards left[] and i for counting turns
    //i was going to be used to up the pet points gotten per round but we 
    //drastically simplified it lol
    public int i = 0;
    public int[] hand;
    public string[] cardsLeft;

    // Start is called before the first frame update
    void Start() {
        //initialized for calling the carddata and deck1definition scripts
        cardData = cards.GetComponent<CardData>();
        deck1Definition = playerDeck.GetComponent<Deck1Definition>();
        //resizes the cardsLeft array to the ammount of cards in a deck
        //this was done seprately and not when the array was created bc that would be a long line
        Array.Resize(ref cardsLeft, 25);
        deck1Definition.deck1.CopyTo(cardsLeft, 0);
    }

    // Update is called once per frame
    void Update() {
        //draws cards when it becomes the player's turn
        if (MainHandler.mainHandler.isTurn == true && MainHandler.mainHandler.cardsDrawn == 0) {
            i++;
            //creates a random number from 0-24 to call from the deck1[]
            int cardIndex = Mathf.FloorToInt(Random.value * 24);
            //checks if that number is the same as previous to avoid drawing the same card twice
            if (MainHandler.mainHandler.playerDeckNum == 1){
                while(cardsLeft[cardIndex]=="") {
                    cardIndex = Mathf.FloorToInt(Random.value * 24);
                }
                //resizes the hand[] to fit all cards drawn
                Array.Resize(ref hand, hand.Length + i);
                hand[i - 1] = cardIndex;
                //deletes the card in the cardsleft[] to keep track of cards drawn
                cardsLeft[cardIndex] = "";
                MainHandler.mainHandler.cardsDrawn++;
            }
        }
    }

    //returns the card's name (ex: "bitchcunt")
    public string getHandCard(int index) {
        if (index <= hand.Length) return deck1Definition.getDeck1(hand[index]);
        else return "that's not a proper index! uwu";
    }
}

