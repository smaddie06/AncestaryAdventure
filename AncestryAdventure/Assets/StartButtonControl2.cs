using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StartButtonControl2 : MonoBehaviour
{
    public string mapStart = "Test";
    public string settingsScreen = "settings6";
    public string testVariable ;
    

    public void NewGameButton(){
        SceneManager.LoadScene(mapStart);
        Debug.Log("HI");
    }

    public void SettingsButton(){
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
}