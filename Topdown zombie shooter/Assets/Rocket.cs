using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float damage;
    Rigidbody2D rb;
    public GameObject[] objectsToActivate;

    private Transform zombieRoot;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        zombieRoot = GameManager.Instance.zombiesRoot;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       

            foreach (var item in objectsToActivate)
            {
                item.SetActive(true);
            }
        Debug.Log(GameManager.ZombiesAlive);
            for (int i = 0; i < GameManager.ZombiesAlive; i++)
            {
                double distance = 
                Mathf.Sqrt(Mathf.Pow(
                    transform.position.x - zombieRoot.GetChild(i).position.x,2) 
                    + Mathf.Pow(transform.position.y - zombieRoot.GetChild(i).position.y, 2));
            Debug.Log(distance);
                if (distance < 50)
                {
               
                //zombies.GetChild(i).gameObject.GetComponent<ZombieAI>().takedamage(damage);
                //Destroy(zombieRoot.GetChild(i).gameObject);
                zombieRoot.GetChild(i).gameObject.GetComponent<ZombieAI>().takedamage(damage);
                
                }


            }


            rb.velocity = Vector3.zero;

            Destroy(this.gameObject, 0.25f);

    }


}
