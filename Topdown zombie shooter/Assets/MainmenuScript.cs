using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainmenuScript : MonoBehaviour
{
    public Button[] nappulat;
    TMP_Text TEXT;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        nappulat[0].onClick.AddListener(start);
        nappulat[1].onClick.AddListener(controls);
        nappulat[2].onClick.AddListener(back);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void start()
    {
        SceneManager.LoadScene("tilemap");
    }

    private void controls()
    {
        menu.SetActive(false);
        TEXT.enabled = true;    
    }

    private void back()
    {
        menu.SetActive(true);
    }
    
}
