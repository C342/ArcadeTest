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

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Car != null)
            {
                Car.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
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

    public void Start(string)
    {
        SceneManager.LoadScene("");
    }
}