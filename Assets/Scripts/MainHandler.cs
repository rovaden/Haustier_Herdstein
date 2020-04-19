using UnityEngine;

public class MainHandler : MonoBehaviour
{
    // this static variable allows us to call on this script without needing a gameObject for a reference
    public static MainHandler mainHandler;

    // these are all variables that will be used in other script but are being held in here
    [System.NonSerialized] public int difficulty;

    [System.NonSerialized] public bool isTurn;

    [System.NonSerialized] public int playerHealth = 69;
    [System.NonSerialized] public int enemyHealth = 69;

    [System.NonSerialized] public int petPoints;
    [System.NonSerialized] public int enemyPetPoints;

    [System.NonSerialized] public int[] playerBoard = {0, 0, 0};
    [System.NonSerialized] public int[] enemyBoard = {1, 1, 1};

    [System.NonSerialized] public int playerDeckNum = 1;

    [System.NonSerialized] public int cardsDrawn;

    [System.NonSerialized] public int playerProfile;

    // this makes sure that this object is the only object of this kind unless we load a scene with the same script than this will be replaced
    void Awake() {
        if (mainHandler == null) {
            DontDestroyOnLoad(this);
            mainHandler = this;
        } else if (mainHandler != null) Destroy(gameObject);
    }
}
