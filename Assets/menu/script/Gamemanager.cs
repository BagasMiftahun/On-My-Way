using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject panelpause;
    // Start is called before the first frame update
    public void PauseControl()
    {
        if (Time.timeScale == 1)
        {
            panelpause.SetActive(true);
            Time.timeScale = 0;
        } else
        {
            Time.timeScale = 1;
            panelpause.SetActive(false);
        }
    }
    public void menu()
    {
        Application.LoadLevel(0);
    }
}
