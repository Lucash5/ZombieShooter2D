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

    // Start is called before the first frame update
    void Start()
    {
        nappulat[0].onClick.AddListener(start);
        nappulat[1].onClick.AddListener(controls);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void start()
    {
        SceneManager.LoadScene("Level1");
    }

    private void controls()
    {
        TEXT.enabled = true;    
    }

}
