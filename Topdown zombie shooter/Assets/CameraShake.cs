using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraShake : MonoBehaviour
{
    bool cooldown;
    public Transform player;
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
        else
        {
            Camera.main.transform.localPosition = new Vector3(player.position.x, player.position.y, Camera.main.transform.position.z);
        }


        

    }

    IEnumerator shake()
    {
        cooldown = true;
        yield return new WaitForSeconds(0.001f);
        Camera.main.transform.localPosition = new Vector3(player.position.x + Random.Range(-0.1f, 0.1f), player.position.y - Random.Range(-0.1f, 0.1f), -10);
        cooldown = false;
    }
}
