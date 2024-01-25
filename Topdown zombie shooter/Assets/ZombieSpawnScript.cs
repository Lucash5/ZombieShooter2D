using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ZombieSpawnScript : MonoBehaviour
{

    int num1;
    int num2;
    bool cooldown;
    public GameObject zombie;
    public GameObject player;

    public int maxzombiecount = 40;
    public float zombiespawnspeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cooldown == false && GameManager.ZombiesAlive < maxzombiecount)
        {
            StartCoroutine(spawnzombie());
        }
    }

    IEnumerator spawnzombie()
    {
        GameManager.ZombiesAlive += 1;
        cooldown = true;
        num1 = Random.Range(-50, 50);
        num2 = Random.Range(-50, 50);
        GameObject zomb = Instantiate(zombie);
        if (zombie != null)
        {
        zomb.transform.position = new Vector2(num1, num2);
        zomb.name = "Enemy";
        zomb.GetComponent<ZombieAI>().player = player.transform;
        zomb.transform.SetParent(GameManager.Instance.zombiesRoot);
        }
        yield return new WaitForSeconds(zombiespawnspeed);
        cooldown = false;
    }
}
