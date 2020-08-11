using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtBoss : MonoBehaviour {

    public int damageToGive = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BossOne") {
            other.gameObject.GetComponent<BossHealthManager>().HurtBoss(damageToGive);
        }
    }
}
