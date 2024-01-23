using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    bool cooldown;
    public float health;
    public float speed;
    public float damage;
    public Transform player;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        Vector2 direction = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);

        transform.right = direction;

        rb.velocity = direction;
    }

    public void takedamage(float dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
       
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().takingdamage(damage);
        }
    }*/

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && cooldown == false)
        {
            StartCoroutine(attackcooldown());
            collision.gameObject.GetComponent<PlayerMovement>().takingdamage(damage);
        }
    }

    IEnumerator attackcooldown()
    {
        cooldown = true;
        yield return new WaitForSeconds(2);
        cooldown = false;
    }

}
