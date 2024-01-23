using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraShake : MonoBehaviour
{
    bool cooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown == false && Input.GetMouseButton(0))
        {
            StartCoroutine(shake());
        }


        

    }

    IEnumerator shake()
    {
        cooldown = true;
        yield return new WaitForSeconds(0.1f);
        Camera.main.transform.localPosition = new Vector3(Random.Range(-0.02f, 0.02f), Random.Range(-0.02f, 0.02f), -10);
        cooldown = false;
    }
}
