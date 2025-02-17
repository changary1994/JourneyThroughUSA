using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SceneSwitcher : MonoBehaviour
{
    GameObject name;
    //Opens the scene of the main game
    private void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("MusicVolume", .3f);
    }
    public void playGame()
    {
        name = GameObject.Find("Name");
        PlayerData.Instance.SetName(name.GetComponent<Text>().text);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    //Opens the scene for the quiz focused game
    public void playQuiz()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    //Shows the scene for the instructions
    public void playInstructions1()
    {
        SceneManager.LoadScene(8, LoadSceneMode.Single);
    }

    public void playInstructions2()
    {
        SceneManager.LoadScene(9, LoadSceneMode.Single);
    }

    public void playInstructions3()
    {
        SceneManager.LoadScene(10, LoadSceneMode.Single);
    }

    public void playInstructions4()
    {
        SceneManager.LoadScene(11, LoadSceneMode.Single);
    }

    //Hosts the menu for the game
    public void playMenu()
    {
        //Data.complete = true;
        Destroy(GameObject.Find("GameObject"));
        Destroy(GameObject.Find("Question"));
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    //Loads the pre survey before playing the quiz game mode
    public void playQuizPreSurvey()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

    //Loads the post survey after playing the quiz game mode
    public void playQuizPostSurvey()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }

    //Lets you choose your difficulty level before playing
    public void playLevelSelect()
    {
        SceneManager.LoadScene(5, LoadSceneMode.Single);
    }

    public void playSettings()
    {
            SceneManager.LoadScene("settings");
    }

    public void playHighScore()
    {
        SceneManager.LoadScene(7, LoadSceneMode.Single);
    }


}
