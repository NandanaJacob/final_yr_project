using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAskLocationScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("AskLocationScene");
    }
     public void BackToWelcome()
    {
        SceneManager.LoadScene("WelcomeScene");
    }

     public void Continue()
    {
        SceneManager.LoadScene("WelcomeScene");
    }

    public void GoToArrowScene()
    {
        SceneManager.LoadScene("try_arrow");
    }
}
