using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
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
 

        Vector2 direction = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);

        transform.right = direction;

        rb.AddForce(transform.right * 5);
    }
}
