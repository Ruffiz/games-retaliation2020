using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth = 100;
    public int playerCurrentHealth;


	void Start ()
    {
        playerCurrentHealth = playerMaxHealth;
	}
	

	void Update ()
    {
        if (playerCurrentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("gameover");
        }
	}

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void BossHurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void SetPlayerMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
