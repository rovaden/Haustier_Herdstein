using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Select_Button : MonoBehaviour
{
    //declaring the class and name of each button
    public Button Level1Button;
    public Button Level2Button;
    public Button Level3Button;
    public Button BackButton;

    void Start() {
        //getting component for each button and adding a listener to check if button is clicked
        ButtonDefining();
    }

    private void ButtonDefining() {
        Button Lvl1 = Level1Button.GetComponent<Button>();
        Lvl1.onClick.AddListener(Lvl1Clicked);

        Button Lvl2 = Level2Button.GetComponent<Button>();
        Lvl2.onClick.AddListener(Lvl2Clicked);

        Button Lvl3 = Level3Button.GetComponent<Button>();
        Lvl3.onClick.AddListener(Lvl3Clicked);

        Button Back = BackButton.GetComponent<Button>();
        Back.onClick.AddListener(BackButtonClicked);
    }

    //functions for what to do as each button is clicked
    // every function loads the same scene but will change the difficulty based on which buton was clicked
    void Lvl1Clicked() {
        SceneManager.LoadScene("Playing Scene");
        MainHandler.mainHandler.difficulty = 1;
    }

    void Lvl2Clicked() {
        SceneManager.LoadScene("Playing Scene");
        MainHandler.mainHandler.difficulty = 2;
    }

    void Lvl3Clicked() {
        SceneManager.LoadScene("Playing Scene");
        MainHandler.mainHandler.difficulty = 3;
    }

    void BackButtonClicked() {
        SceneManager.LoadScene("Start Screen");
    }
}