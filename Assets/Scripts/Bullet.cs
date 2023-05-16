using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float power;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * power * -1;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player") {
            
            collision.gameObject.GetComponent<Status>().HP--;
            Debug.Log(collision.gameObject.GetComponent<Status>().HP);

            GameObject.Find("HPBar").GetComponent<HpBar>().UpdateHPValue();
        }

        Destroy(this.gameObject);
    }
}
