using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StartButtonControl2 : MonoBehaviour
{
    public string SettingsMenu = "SettingsMenu";
    public string testVariable ;
    

    public void NewGameButton(){
        SceneManager.LoadScene("Countryside");
        Debug.Log("HI");
    }
    // Start is called before the first frame update
}