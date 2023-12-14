
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button playButton;
    public Button creditButton;
    public Button exitButton;
    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        creditButton.onClick.AddListener(Credits);
        exitButton.onClick.AddListener(ExitGame);        
    }
    private void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void Credits()
    {
        SceneManager.LoadScene("Credit");
    }
    private void ExitGame()
    {
        Application.Quit();
    }
}
