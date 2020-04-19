using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class HandHandler : MonoBehaviour
{
    //variables to detect a double click for hand toggle
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    //created game objects and scripts to call variable from different scripts
    public SpriteRenderer handSpriteRender;
    private Sprite[] cardSprites;

    public GameObject playerDeck;
    DeckHandler deckHandler;
    
    SpriteArray spriteArray;

    //used to resize the hand sprite so the player can read stats
    Vector2 pos;
    int sortingOrder;
    bool showingHand;
    int emptySlot;

    //more gameobject declarations used to modify/retrieve stuff
    public Button place;

    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    SpriteRenderer card1Sprite;
    SpriteRenderer card2Sprite;
    SpriteRenderer card3Sprite;

    //the index in deck1[] of the card placed
    public int cardPlaced;

    public GameObject atkTxt1;
    public GameObject atkTxt2;
    public GameObject atkTxt3;
    public GameObject hlthTxt1;
    public GameObject hlthTxt2;
    public GameObject hlthTxt3;
    TextMesh atkTxtMsh1;
    TextMesh atkTxtMsh2;
    TextMesh atkTxtMsh3;
    TextMesh hlthTxtMsh1;
    TextMesh hlthTxtMsh2;
    TextMesh hlthTxtMsh3;

    public GameObject cards;
    CardData cardData;

    // Start is called before the first frame update
    void Start() {
        //defaults the hand to be untoggled
        showingHand = false;
        pos = transform.position;
        handSpriteRender = gameObject.GetComponent<SpriteRenderer>();
        //resize the sprite[] to 40, to hold all card sprites
        Array.Resize(ref cardSprites, 50);
        Resources.LoadAll<Sprite>("Assets/Cards").CopyTo(cardSprites, 0);
        //initializes array and used scripts
        spriteArray = this.GetComponent<SpriteArray>();
        deckHandler = playerDeck.GetComponent<DeckHandler>();
        cardData = cards.GetComponent<CardData>();
        //initializes and tells the button "place" what to do
        Button placeCard = place.GetComponent<Button>();
        placeCard.onClick.AddListener(PlaceCards);
        //initializes the card places and attack text
        card1Sprite = card1.GetComponent<SpriteRenderer>();
        card2Sprite = card2.GetComponent<SpriteRenderer>();
        card3Sprite = card3.GetComponent<SpriteRenderer>();
        atkTxtMsh1 = atkTxt1.GetComponent<TextMesh>();
        atkTxtMsh2 = atkTxt2.GetComponent<TextMesh>();
        atkTxtMsh3 = atkTxt3.GetComponent<TextMesh>();
        hlthTxtMsh1 = hlthTxt1.GetComponent<TextMesh>();
        hlthTxtMsh2 = hlthTxt2.GetComponent<TextMesh>();
        hlthTxtMsh3 = hlthTxt3.GetComponent<TextMesh>();

    }

    //used to sense a double click
    bool DoubleClick() {
        if (Input.GetMouseButtonDown(0)) {
            clicked++;
            if (clicked == 1) clicktime = Time.time;
        }
        if (clicked > 1 && Time.time - clicktime < clickdelay) {
            clicked = 0;
            clicktime = 0;
            return true;
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
        return false;
    }

    // Update is called once per frame
    void Update() {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
        //makes the drawn card appear in the hand
        if (deckHandler.hand.Length > 0) handSpriteRender.sprite = spriteArray.spriteArray[deckHandler.hand[deckHandler.hand.GetUpperBound(0)]];
        if (deckHandler.hand.Length <= 0) { 
            handSpriteRender.sprite = null;
            place.gameObject.SetActive(false);
        }
        //toggles hand appearance
        if (DoubleClick()) {
            if (!showingHand) {
                transform.localScale = new Vector2(1f, 1f);
                transform.position = new Vector2(-5.46f, 0f);
                sortingOrder = 1;
                showingHand = true;
                if (SpaceOnField()) place.gameObject.SetActive(true);
            } else {
                transform.localScale = new Vector2(0.3f, 0.3f);
                transform.position = pos;
                sortingOrder = 0;
                showingHand = false;
                place.gameObject.SetActive(false);
            }
        }
    }
    //checks if the slot is empty
    bool SpaceOnField() {
        for(int i = 0; i < MainHandler.mainHandler.playerBoard.Length; i++) {
            if(MainHandler.mainHandler.playerBoard[i] == 0) {
                emptySlot = i;
                return true;
            }
        }
        return false;
    }
    //places the card when "place" is clicked
    void PlaceCards() {
        Collider boxCollider;
        if (emptySlot == 0) {
            //if the slot is empty, it changes the sprite to the sprite in hand, enables box collider for attacking, 
            //and makes the attack and health images appear
            card1Sprite.sprite = handSpriteRender.sprite;
            boxCollider = card1.gameObject.GetComponent<Collider>();
            boxCollider.enabled = true;
            atkTxt1.SetActive(true);
            hlthTxt1.SetActive(true);
            atkTxtMsh1.text = cardData.getAttack(deckHandler.getHandCard(cardPlaced)).ToString();
            hlthTxtMsh1.text = cardData.getHealth(deckHandler.getHandCard(cardPlaced)).ToString();
        }
        else if (emptySlot == 1) {
            card2Sprite.sprite = handSpriteRender.sprite;
            boxCollider = card2.gameObject.GetComponent<Collider>();
            boxCollider.enabled = true;
            atkTxt2.SetActive(true);
            hlthTxt2.SetActive(true);
            atkTxtMsh2.text = cardData.getAttack(deckHandler.getHandCard(cardPlaced)).ToString();
            hlthTxtMsh2.text = cardData.getHealth(deckHandler.getHandCard(cardPlaced)).ToString();
        }
        else {
            card3Sprite.sprite = handSpriteRender.sprite;
            boxCollider = card1.gameObject.GetComponent<Collider>();
            boxCollider.enabled = true;
            atkTxt3.SetActive(true);
            hlthTxt3.SetActive(true);
            atkTxtMsh3.text = cardData.getAttack(deckHandler.getHandCard(cardPlaced)).ToString();
            hlthTxtMsh3.text = cardData.getHealth(deckHandler.getHandCard(cardPlaced)).ToString();
        }
        //removes the card from the hand[]
        cardPlaced = deckHandler.hand[deckHandler.hand.GetUpperBound(0)];
        int cardIdx = Array.IndexOf(deckHandler.hand, cardPlaced);
        List<int> tmp = new List<int>(deckHandler.hand);
        tmp.RemoveAt(cardIdx);
        deckHandler.hand = tmp.ToArray();

        MainHandler.mainHandler.playerBoard[emptySlot] = 1;
    }
}
