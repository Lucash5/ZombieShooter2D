using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void playGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();

    }
}
