using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnScript : MonoBehaviour
{
    int num1;
    int num2;
    bool cooldown;
    public GameObject zombie;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown == false)
        {
            StartCoroutine(spawnzombie());
        }
    }

    IEnumerator spawnzombie()
    {
        cooldown = true;
        num1 = Random.Range(-50, 50);
        num2 = Random.Range(-50, 50);
        GameObject zomb = Instantiate(zombie);
        if (zombie != null)
        {

        zomb.transform.position = new Vector2(num1, num2);
        zomb.name = "Enemy";
            zomb.GetComponent<ZombieAI>().player = player.transform;
        }
        yield return new WaitForSeconds(2f);
        cooldown = false;
    }
}
