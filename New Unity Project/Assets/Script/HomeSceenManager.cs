using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceenManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToPlayground()
    {
        PlayerPrefs.SetInt("CoinCount", 0);
        SceneManager.LoadScene("PlayGround");
    }
    public void ContinuePlay()
    {
        if (PlayerPrefs.HasKey("PrevScene"))
        {
            string prevSceneName = PlayerPrefs.GetString("PrevScene");
            SceneManager.LoadScene(prevSceneName);

        }
          
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}