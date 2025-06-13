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
                float currentX = Car.transform.eulerAngles.x;
                float currentZ = Car.transform.eulerAngles.z;
                Car.transform.rotation = Quaternion.Euler(currentX, 180f, currentZ);
            }
        }

        if (Car != null && RestartText != null)
        {
            if (Car.transform.up.y < 0.1f)
            {
                RestartText.gameObject.SetActive(true);
            }
            else
            {

                RestartText.gameObject.SetActive(false);
            }
        }
    }
}