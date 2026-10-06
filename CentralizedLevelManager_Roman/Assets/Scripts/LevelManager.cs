using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
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
