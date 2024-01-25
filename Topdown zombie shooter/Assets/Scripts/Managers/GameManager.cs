using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Instanssi jota voidaan kutsua mist� vaan
    public static GameManager Instance;

    public PlayerMovement player;
    public Transform zombiesRoot;
    public Transform bulletRoot;

    public static int ZombiesAlive = 0;

    void Awake()
    {
        // tarkistetaan onko GameManagerista olemassa jo instanssi
        // jos ei ole, niin instanssi = t�m� gamemanager
        // Jos on olemassa, niin tuhotaan t�m� objekti

        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);

    }

    private void Update()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
