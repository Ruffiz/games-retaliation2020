using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHurtPlayer : MonoBehaviour {

    public int damageToGive = 20;

	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainCharacter") {
            collision.gameObject.GetComponent<PlayerHealthManager>().BossHurtPlayer(damageToGive);
        }
    }
}
