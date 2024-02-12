using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AskLocationScript : MonoBehaviour
{
    public void BackToWelcome()
    {
        SceneManager.LoadScene("WelcomeScene");
    }

     public void Continue()
    {
        SceneManager.LoadScene("WelcomeScene");
    }
}
