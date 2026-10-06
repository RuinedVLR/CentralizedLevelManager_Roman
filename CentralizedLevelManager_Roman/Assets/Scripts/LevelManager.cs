using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLevel1Load()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnLevel2Load()
    {
        SceneManager.LoadScene("Level2");
    }

    public void OnResultsScreenLoad()
    {
        SceneManager.LoadScene("ResultsScreen");
    }

    public void OnMainMenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }
}
