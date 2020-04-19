using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditButtons : MonoBehaviour
{
    // this is a variable that will allow me to get the button component
    public Button backButton;

    // Start is called before the first frame update
    void Start() {
        // grabs the button component and adds a listener for the onClick event
        Button back = backButton.GetComponent<Button>();
        back.onClick.AddListener(GoBack);
    }

    // goes back to the start screen scene
    void GoBack() {
        SceneManager.LoadScene("Start Screen");
    }
}
