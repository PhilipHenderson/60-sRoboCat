using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int Damage = 1;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            print("Hit Enemy");
            GameObject.Destroy(gameObject);
        }
    }






}
