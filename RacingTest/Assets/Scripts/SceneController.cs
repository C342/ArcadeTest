using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Transform Car;
    public TextMeshProUGUI RestartText;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Backspace))
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

        if (Input.GetKey(KeyCode.F))
        {
            if (Car != null)
            {
                Vector3 forward = Car.transform.forward;
                Vector3 up = Vector3.up;

                Car.transform.rotation = Quaternion.LookRotation(forward, up);
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