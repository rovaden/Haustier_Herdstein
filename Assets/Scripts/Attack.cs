using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    // these variables allow us to change the text that shows the enemy or player HP
    public Text enemyHP;
    public Text playerHP;

    // these variables allow us to change the text that shows the enemy or player Pet Points
    public Text playerPetPointText;
    public Text enemyPetPointText;

    // these variables allow us to activate or deactivate the arrow images that allow us to attack
    public GameObject attackArrows;
    public GameObject attackArrowLeft;
    public GameObject attackArrowMiddle;
    public GameObject attackArrowRight;
    public GameObject attackArrowFace;

    // booleans that check if we are attacking and where we can attack
    [System.NonSerialized] public bool attacking = false;

    private bool canAttackLeft = false;
    private bool canAttackMiddle = false;
    private bool canAttackRight = false;
    private bool canAttackFace = false;

    int damage;
    int health;
    int enemyDamage;
    int enemyHealth;

    public GameObject cards;
    CardData cardData;
    public GameObject cardInHand;
    HandHandler handHandler;
    public GameObject playerDeck;
    DeckHandler deckHandler;

    // start is called once at the start of the script
    private void Start() {
        cardData = cards.GetComponent<CardData>();
        handHandler = cardInHand.GetComponent<HandHandler>();
        deckHandler = playerDeck.GetComponent<DeckHandler>();
    }

    // Update is called once per frame
    void Update() {
        UpdateText();

        // calls the clicked function which checks if your mouse clicked on something and does actions based on what it clicked
        if (Input.GetMouseButtonDown(0)) Clicked();

            // if in attacking phase than it activates the attack arrows that are necessary
        if (attacking) ActivateAttackArrows();
        else attackArrows.SetActive(false);
    }

    private void CheckForCards() {
        int curr = 0;
        // this for loop goes through an array on MainHandler and checks to see where we can attack
        for (int i = 0; i < MainHandler.mainHandler.enemyBoard.Length; i++) {
            if (MainHandler.mainHandler.enemyBoard[i] == 1) {
                canAttackFace = false;
                if (i == 0) canAttackLeft = true;
                else if (i == 1) canAttackMiddle = true;
                else canAttackRight = true;
            }
            else curr++;
        }
        if (curr == 3) {
            canAttackLeft = false;
            canAttackMiddle = false;
            canAttackRight = false;
            canAttackFace = true;
        }
    }

    private void UpdateText() {
        // updates text for pet points and health
        enemyHP.text = MainHandler.mainHandler.enemyHealth.ToString() + " HP";
        playerHP.text = MainHandler.mainHandler.playerHealth.ToString() + " HP";
        playerPetPointText.text = MainHandler.mainHandler.petPoints.ToString() + " PP";
        enemyPetPointText.text = MainHandler.mainHandler.enemyPetPoints.ToString() + " PP";
    }

    private void Clicked() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo)) {
            if (hitInfo.collider.gameObject.tag == "Played cards") {
                // checks to see if any cards are played. if so than you can attack them but not the face. if not than you can attack face.
                CheckForCards();
                damage = 2; //cardData.getAttack(deckHandler.getHandCard(handHandler.cardPlaced));
                health = 2; //cardData.getHealth(deckHandler.getHandCard(handHandler.cardPlaced));
                attacking = true;
            }

            if(hitInfo.collider.gameObject.tag == "Attack left") {
                int enemyDamage = 2;
                int enemyHealth = 2;
                // grab the info of the card in the left slot. deal dmg based on the card you have picked.
                enemyHealth = enemyHealth - damage;
                health = health - enemyDamage;
                attacking = false;
            }
            else if (hitInfo.collider.gameObject.tag == "Attack middle") {
                int enemyDamage = 2;
                int enemyHealth = 2;
                // grab the info of the card in the left slot. deal dmg based on the card you have picked.
                enemyHealth = enemyHealth - damage;
                health = health - enemyDamage;
                attacking = false;
            }
            else if (hitInfo.collider.gameObject.tag == "Attack right") {
                int enemyDamage = 2;
                int enemyHealth = 2;
                // grab the info of the card in the left slot. deal dmg based on the card you have picked.
                enemyHealth = enemyHealth - damage;
                health = health - enemyDamage;
                attacking = false;
            }
            else if (hitInfo.collider.gameObject.tag == "Attack face") {
                // deal damage to enemy *add later, based on the cards attack* than end attack
                MainHandler.mainHandler.enemyHealth = MainHandler.mainHandler.enemyHealth - damage;
                attacking = false;
            }
        }
    }

    private void ActivateAttackArrows() {
        // activates arrows based on where the player can attack
        attackArrows.SetActive(true);
        if (canAttackLeft) attackArrowLeft.SetActive(true);
        else attackArrowLeft.SetActive(false);

        if (canAttackMiddle) attackArrowMiddle.SetActive(true);
        else attackArrowMiddle.SetActive(false);

        if (canAttackRight) attackArrowRight.SetActive(true);
        else attackArrowRight.SetActive(false);

        if (canAttackFace) attackArrowFace.SetActive(true);
        else attackArrowFace.SetActive(false);
    }
}
