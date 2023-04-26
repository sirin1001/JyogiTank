using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            var pos = transform.position;
            var rot = transform.rotation;

            pos.x += 0.1f;

            Instantiate(bullet, pos, rot);
        }
    }
}
