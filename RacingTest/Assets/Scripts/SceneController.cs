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
    public float RotationSpeed = 90f;

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
            Quaternion targetRotation = Quaternion.Euler(0f, 180f, 0f);

            Car.transform.rotation = Quaternion.RotateTowards(
                Car.transform.rotation,
                targetRotation,
                RotationSpeed * Time.deltaTime);
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