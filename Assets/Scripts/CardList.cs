using UnityEngine;

public class CardList : MonoBehaviour
{
    //uses the cardData script and deck1definition script from the player deck object
    public CardData cardData;
    public GameObject playerDeck;
    Deck1Definition deck1Definition;
    // Start is called before the first frame update
    void Start() {
        CardData cardData = gameObject.GetComponent<CardData>();
        CreateCards();
        DefineCards();
        deck1Definition = playerDeck.GetComponent<Deck1Definition>();
        deck1Definition.setDeck1();
    }

    //cards are listed
    public void CreateCards() {
        CardData cardData = gameObject.GetComponent<CardData>();
        //0-4
        cardData.createCard("Happy Parrot"); 
        cardData.createCard("Bathtub Cat"); 
        cardData.createCard("Baffled Cat"); 
        cardData.createCard("DOGE"); 
        cardData.createCard("doge");
        //5-9
        cardData.createCard("Patient Dog"); 
        cardData.createCard("Gimmie Butt"); 
        cardData.createCard("dogE"); 
        cardData.createCard("Floof"); 
        cardData.createCard("Doge");
        //10-14
        cardData.createCard("Ready-To-Eat-Cat"); 
        cardData.createCard("Seer Dog"); 
        cardData.createCard("Drowsy Dog Duo"); 
        cardData.createCard("No"); 
        cardData.createCard("Don't-Touch-Me Cat");
        //15-19
        cardData.createCard("d-o-g"); 
        cardData.createCard("Guilty Dog"); 
        cardData.createCard("Asleep Dog"); 
        cardData.createCard("Alert Dog"); 
        cardData.createCard("Allison's Dog");
        //20-24
        cardData.createCard("Teething Dog"); 
        cardData.createCard("Blurry Thing"); 
        cardData.createCard("dOg");
        cardData.createCard("DoG");
        cardData.createCard("Grim Reaper Dog"); 
        //25-29
        cardData.createCard("Dino");
        cardData.createCard("Volunteering Cat"); 
        cardData.createCard("dog"); 
        cardData.createCard("DOG"); 
        cardData.createCard("Bird Bussy"); 
        //30-34
        cardData.createCard("Doug");
        cardData.createCard("Sick Dog"); 
        cardData.createCard("Elevated Dog");
        cardData.createCard("Veteran Dog");
        cardData.createCard("Polite Dog"); 
        //35-39
        cardData.createCard("Christmas Tree Cat"); 
        cardData.createCard("Seeking Mellowbean");
        cardData.createCard("Protective Mellowbean"); 
        cardData.createCard("Burned Out Mellowbean");
        cardData.createCard("Blind Sage Mellowbean"); 
        //40-44
        cardData.createCard("Generous Mellowbean"); 
        cardData.createCard("Waggy Tail Dog");
        cardData.createCard("Doggo"); 
        cardData.createCard("Healing Succulent"); 
        cardData.createCard("BitchCunt"); 
        //45-49
        cardData.createCard("Aesthetic Cat"); 
        cardData.createCard("Big Dog");
        cardData.createCard("Happy Double-Dogs"); 
        cardData.createCard("Tiny Snake uwu"); 
        cardData.createCard("Oblivious Turtle"); 
    }

    //cards are defined in a nice and neat order for future refrencing, instead of scrolling through the organization logic in cardData.cs
    public void DefineCards() {
        CardData cardData = gameObject.GetComponent<CardData>();
        //0-4
        cardData.setCardDefinition("Happy Parrot", 4, 1, 1);
        cardData.setCardDefinition("Bathtub Cat", 3, 2, 5);
        cardData.setCardDefinition("Baffled Cat", 3, 2, 3);
        cardData.setCardDefinition("DOGE", 3, 3, 3);
        cardData.setCardDefinition("doge", 4, 3, 5);
        //5-9
        cardData.setCardDefinition("Patient Dog", 4, 3, 6);
        cardData.setCardDefinition("Gimmie Butt", 3, 1, 1);
        cardData.setCardDefinition("dogE", 3, 4, 3);
        cardData.setCardDefinition("Floof", 3, 1, 3);
        cardData.setCardDefinition("Doge", 1, 2, 2);
        //10-14
        cardData.setCardDefinition("Ready-To-Eat Cat", 6, 2, 3);
        cardData.setCardDefinition("Seer Dog", 4, 3, 3);
        cardData.setCardDefinition("Drowsy Dog Duo", 4, 5, 5);
        cardData.setCardDefinition("No", 5, 2, 6);
        cardData.setCardDefinition("Don't-Touch-Me Cat", 6, 2, 6);
        //15-19
        cardData.setCardDefinition("d-o-g", 7, 7, 7);
        cardData.setCardDefinition("Guilty Dog", 3, 7, 5);
        cardData.setCardDefinition("Asleep Dog", 4, 3, 8);
        cardData.setCardDefinition("Alert Dog", 0, 3, 8);
        cardData.setCardDefinition("Allison's Dog", 2, 1, 1);
        //20-24
        cardData.setCardDefinition("Teething Dog", 5, 1, 4);
        cardData.setCardDefinition("Blurry Thing", 4, 3, 3);
        cardData.setCardDefinition("dOg", 3, 4, 2);
        cardData.setCardDefinition("DoG", 3, 2, 4);
        cardData.setCardDefinition("Grim Reaper Dog", 6, 4, 5);
        //25-29
        cardData.setCardDefinition("Dino", 6, 7, 4);
        cardData.setCardDefinition("Volunteering Cat", 2, 2, 4);
        cardData.setCardDefinition("dog", 1, 1, 2);
        cardData.setCardDefinition("DOG", 1, 2, 1);
        cardData.setCardDefinition("Uncomfortable Parrot", 2, 1, 1);
        //30-34
        cardData.setCardDefinition("Doug", 2, 2, 3);
        cardData.setCardDefinition("Sick Dog", 5, 3, 5);
        cardData.setCardDefinition("Elevated Dog", 4, 4, 2);
        cardData.setCardDefinition("Veteran Dog", 2, 2, 2);
        cardData.setCardDefinition("Polite Dog", 5, 3, 4);
        //35-39
        cardData.setCardDefinition("Christmas Tree Cat", 5, 4, 5);
        cardData.setCardDefinition("Seeking Mellowbean", 3, 1, 1);
        cardData.setCardDefinition("Protective Mellowbean", 3, 1, 1);
        cardData.setCardDefinition("Burned Out Mellowbean", 3, 1, 1);
        cardData.setCardDefinition("Blind Sage Mellowbean", 3, 1, 1);
        //40-44
        cardData.setCardDefinition("Generous Mellowbean", 3, 1, 1);
        cardData.setCardDefinition("Waggy Tail Dog", 4, 3, 3);
        cardData.setCardDefinition("Doggo", 4, 5, 5);
        cardData.setCardDefinition("Healing Succulent", 1, 0, 2);
        cardData.setCardDefinition("BitchCunt", 5, 0, 0);
        //45-49
        cardData.setCardDefinition("Aesthetic Cat", 3, 3, 3);
        cardData.setCardDefinition("Big Dog", 7, 3, 10);
        cardData.setCardDefinition("Happy Double-Dogs", 4, 3, 5);
        cardData.setCardDefinition("Tiny Snake", 2, 3, 1);
        cardData.setCardDefinition("Oblivious Turtle", 4, 1, 7);


    }

}