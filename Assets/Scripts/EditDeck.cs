using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EditDeck : MonoBehaviour
{
    //Declaring the variables for each button in the start screen
    public Button backButton;

    void Start()
    {
        //getting component for each button and adding a listener to check if button is clicked
        ButtonDefining();
    }

    private void ButtonDefining()
    {
        // gets all the button components and adds listener for onClick event
        Button back = backButton.GetComponent<Button>();
        back.onClick.AddListener(BackClicked);

    }

    //functions for what to do as each button is clicked
    void BackClicked()
    {
        SceneManager.LoadScene("Start Screen");
    }

}
