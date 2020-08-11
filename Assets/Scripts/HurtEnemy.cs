using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive = 20;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ZombieOne" || other.gameObject.tag == "ZombieTwo")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
        }
    }
}
