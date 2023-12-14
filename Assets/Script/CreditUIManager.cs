using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Button CreditButton;
    void Start()
    {
        CreditButton.onClick.AddListener(MainMenu);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
