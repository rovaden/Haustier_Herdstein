using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreenButton : MonoBehaviour
{
    //Declaring the variables for each button in the start screen
    public Button playButton;
    public Button quitButton;
    public Button creditButton;
    public Button editDeckButton;
    public Button settingsButton;

	void Start () {
        //getting component for each button and adding a listener to check if button is clicked
        ButtonDefining();
    }

    private void ButtonDefining() {
        // gets all the button components and adds listener for onClick event
        Button play = playButton.GetComponent<Button>();
        play.onClick.AddListener(PlayClicked);

        Button quit = quitButton.GetComponent<Button>();
        quit.onClick.AddListener(QuitClicked);

        Button credits = creditButton.GetComponent<Button>();
        credits.onClick.AddListener(CreditsClicked);

        Button editDeck = editDeckButton.GetComponent<Button>();
        editDeck.onClick.AddListener(EditDeckClicked);

        Button settings = settingsButton.GetComponent<Button>();
        settings.onClick.AddListener(SettingsClicked);
    }

    //functions for what to do as each button is clicked
    void PlayClicked() {
        SceneManager.LoadScene("Level Select");
	}

    void QuitClicked() {
        //quiting the game completely
        Application.Quit();
    }

    void CreditsClicked() {
        // goes to credit scene
        SceneManager.LoadScene("Credits");
    }

    void EditDeckClicked() {
        // goes to deck edit scene
        SceneManager.LoadScene("Deck Edit Scene");
    }

    void SettingsClicked() {
        // goes to the settings scene but not really because we didnt have time
        Debug.Log("You are now in settings");
    }
}
