using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Control : MonoBehaviour
{
    public string newScene;

    public void NextScene()
    {
        SceneManager.LoadScene(newScene);
    }
}