using UnityEngine;

public class PlayerPicture : MonoBehaviour
{
    public Sprite[] playerpfp;
    SpriteRenderer pfpSprite;

    // Start is called before the first frame update
    void Start() {
        pfpSprite = gameObject.GetComponent<SpriteRenderer>();
        // changes profile picture sprite and size
        pfpSprite.sprite = playerpfp[MainHandler.mainHandler.playerProfile];
        this.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
    }
}
