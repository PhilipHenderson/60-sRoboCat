using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void onCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
