using UnityEngine;

public class CardResize : MonoBehaviour
{
    // the player pfp holds the attack script which we need to use and this variable allows that
    public GameObject playerpfp;
    Attack attack;

    // the vector2 holds the position of the gameobject that will be moved
    Vector2 pos;
    int sortingOrder;

    // start is called once at the start of the script
    private void Start() {
        pos = transform.position;
        attack = playerpfp.GetComponent<Attack>();
    }

    // update is called once per frame
    private void Update()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
        if (attack.attacking) ResetCard();
    }

    // this function is called when the mouse is over the sprite
    private void OnMouseOver() {
        if (attack.attacking == false) {
        transform.localScale = new Vector2(1f, 1f);
        transform.position = new Vector2(pos[0], 0);
        sortingOrder = 1;
        }
    }

    // this function is called when the mouse exits the sprite
    private void OnMouseExit() {
        ResetCard();
    }

    // this function resets the position of the card using the pos variable
    private void ResetCard() {
        transform.localScale = new Vector2(0.3f, 0.3f);
        transform.position = pos;
        sortingOrder = 0;
    }
}
