using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public GameObject Car;
    public TextMeshProUGUI RestartText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level");
        }

        if (Car != null && RestartText != null)
        {
            if (Car.transform.up.y < 0f)
            {
                RestartText.gameObject.SetActive(true);
            }
            else
            {

                RestartText.gameObject.SetActive(false);
            }
        }
    }

    public static void switchScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public static void QuitGame()
    {
        Application.Quit();
    }
}