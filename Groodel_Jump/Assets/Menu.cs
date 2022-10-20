using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string scene_name;
    public void load()
    {
        SceneManager.LoadScene(scene_name);
        Time.timeScale = 1f;
    }

    public void quitter()
    {
        Application.Quit();
    }
}
