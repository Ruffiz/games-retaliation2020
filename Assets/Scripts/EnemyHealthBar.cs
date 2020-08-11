using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour {

    public Slider enemyHealthBar;
    public EnemyHealthManager enemyHealth;

	void Start () {
		
	}
	
	void Update () {
        enemyHealthBar.maxValue = enemyHealth.enemyMaxHealth;
        enemyHealthBar.value = enemyHealth.enemyCurrentHealth;
	}
}
