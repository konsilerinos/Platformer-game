using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void Music()
    {
        if(GameObject.Find("Gilka").GetComponent<Image>().color == new Color(255, 255, 255, 255))
        {
            GameObject.Find("Gilka").GetComponent<Image>().color = new Color(0, 0, 0, 255);
        }
        else
        {
            GameObject.Find("Gilka").GetComponent<Image>().color = new Color(255, 255, 255, 255);
        }
        Debug.Log("Music");
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
        Debug.Log("Options");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Return");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
    }
}
