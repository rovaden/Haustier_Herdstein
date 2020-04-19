using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Select_Button : MonoBehaviour
{
    //declaring the class and name of each button
    public Button Level1Button;
    public Button Level2Button;
    public Button Level3Button;

    [HideInInspector] public int difficulty;

    void Start() {
        //getting component for each button and adding a listener to check if button is clicked
        Button Lvl1 = Level1Button.GetComponent<Button>();
        Lvl1.onClick.AddListener(Lvl1Clicked);

        Button Lvl2 = Level2Button.GetComponent<Button>();
        Lvl2.onClick.AddListener(Lvl2Clicked);

        Button Lvl3 = Level3Button.GetComponent<Button>();
        Lvl3.onClick.AddListener(Lvl3Clicked);
    }

    //functions for what to do as each button is clicked

    // every function loads the same scene but will change the difficulty based on which buton was clicked
    void Lvl1Clicked() {
        Debug.Log("You have entered Level 1");
        SceneManager.LoadScene("Playing Scene");
        difficulty = 1;
        Debug.Log(difficulty);
    }

    void Lvl2Clicked() {
        Debug.Log("You have entered Level 2");
        SceneManager.LoadScene("Playing Scene");
        difficulty = 2;
        Debug.Log(difficulty);
    }

    void Lvl3Clicked() {
        Debug.Log("You have entered Level 3");
        SceneManager.LoadScene("Playing Scene");
        difficulty = 3;
        Debug.Log(difficulty);
    }

}