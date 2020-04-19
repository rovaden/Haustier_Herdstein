using UnityEngine;
using UnityEngine.UI;

public class EndTurn : MonoBehaviour
{
    // creates variables for the button and to access the MainHandler script.
    public Button endTurnButton;

    // Start is called before the first frame update
    void Start() {
        // accesses the MainHandler script and Button component
        MainHandler.mainHandler.isTurn = true;

        Button turnEnder = endTurnButton.GetComponent<Button>();
        turnEnder.onClick.AddListener(endTurn);
    }

    // ends the turn of the player
    void endTurn() {
        MainHandler.mainHandler.isTurn = false;
        MainHandler.mainHandler.cardsDrawn = 0;
    }
}
