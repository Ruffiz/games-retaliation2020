using System.Collections;
using UnityEngine;

public class DamageZone : MonoBehaviour {

    public bool doesDamage;
    public float damage = 10;
    
	private void OnTriggerStay(Collider col)
    {

        if (col.tag == "Player")
            col.SendMessage((doesDamage) ? "PlayerDamage" : "HealPlayer", Time.deltaTime * damage);
    }
}
