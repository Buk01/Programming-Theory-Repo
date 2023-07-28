using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    bool spawn;

    // Start is called before the first frame update
    void Start()
    {
        spawn = GameManager.instance.spawn;
    }
    //Goes back to the main menu
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ToggleSpawn()
    {
        spawn = !spawn;
        GameManager.instance.spawn = spawn;
    }
}
