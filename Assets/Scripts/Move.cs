using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 1f;
    int OnTerrain = 0;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector2 force = new Vector2(x * speed * OnTerrain,0);
        rb.AddForce(transform.right * force,ForceMode2D.Force);

        var scl = transform.localScale;
        if(x > 0)
        {
            scl.z = 1;
        }else if(x < 0) {
            scl.z = -1;
        }
        transform.localScale = scl;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Terrain")
        {
            OnTerrain = 1;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            OnTerrain = 0;
        }
    }
}
