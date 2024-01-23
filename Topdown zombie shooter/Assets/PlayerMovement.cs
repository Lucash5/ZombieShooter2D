using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    static public int killcount;
    public float health;
    bool cooldown;
    public GameObject bullet;
    public float speed;
    Rigidbody2D rb;
    public Transform firepoint;
    public Transform bulletsfolder;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);

        if (Input.GetMouseButton(0) && cooldown == false)
        {
            StartCoroutine(firingboolet());
        }

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.right = direction;
    }

    IEnumerator firingboolet()
    {
        cooldown = true;
        GameObject boolet = Instantiate(bullet);
        boolet.transform.position = firepoint.position;
        boolet.transform.rotation = firepoint.rotation;
        //600
        
        boolet.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000);
        boolet.transform.SetParent(bulletsfolder);
        yield return new WaitForSeconds(0.1f);
        cooldown = false;
        yield return new WaitForSeconds(4);
        if (boolet != null)
        {
            Destroy(boolet);
        }

    }

    public void takingdamage(float dmg)
    {
        health -= dmg;
        Debug.Log(health);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
 
