using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //get the index of current scene using the scene manager and increment it by 1 to load the next scene in the sequence.
    }

    public void stopGame()
    {
        Application.Quit(); //Terminate the application
        Debug.Log("Appication Terminated!"); //for testing in the editor.
    }
}
