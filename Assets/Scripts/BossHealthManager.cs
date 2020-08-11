using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealthManager : MonoBehaviour {
    public int bossMaxHealth = 200;
    public int bossCurrentHealth;

	void Start () {
        bossCurrentHealth = bossMaxHealth;
	}
	
	void Update () {
        if (bossCurrentHealth <= 0) {
            Destroy(gameObject);
            SceneManager.LoadScene("endScene1");
        }
	}

    public void HurtBoss(int damageToGive) {
        bossCurrentHealth -= damageToGive;
    }

    public void SetBossMaxHealth() {
        bossCurrentHealth = bossMaxHealth;
    }
}
