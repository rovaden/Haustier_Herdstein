using UnityEngine;

public class HandHover : MonoBehaviour
{
    public Camera mainCamera;
    Attack attack;

    Vector2 pos;
    int sortingOrder;

    private void Start() {
        pos = transform.position;
        attack = mainCamera.GetComponent<Attack>();
    }

    private void Update() {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
        if (attack.attacking) {
            ResetCard();
        }
    }

    private void OnMouseOver() {
        if (attack.attacking == false) {
            transform.localScale = new Vector2(1.25f, 1.25f);
            transform.position = new Vector2(-5.35f, -2.25f);
            sortingOrder = 1;
        }
    }

    private void OnMouseExit() {
        ResetCard();
    }

    private void ResetCard() {
        transform.localScale = new Vector2(0.3f, 0.3f);
        transform.position = pos;
        sortingOrder = 0;
    }
}
