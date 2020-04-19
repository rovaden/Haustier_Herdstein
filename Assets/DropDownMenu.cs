using UnityEngine;
using UnityEngine.UI;

public class DropDownMenu : MonoBehaviour
{
    Dropdown dropDown;

    // Start is called before the first frame update
    void Start()
    {
        dropDown = gameObject.GetComponent<Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        MainHandler.mainHandler.playerProfile = dropDown.value;
    }
}
