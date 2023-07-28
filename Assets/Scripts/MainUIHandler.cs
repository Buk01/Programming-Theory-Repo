using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    //Goes back to the main menu
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
