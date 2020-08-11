using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour {

    public Slider bossHealthBar;
    public BossHealthManager bossHealth;

    void Start()
    {

    }

    void Update()
    {
        bossHealthBar.maxValue = bossHealth.bossMaxHealth;
        bossHealthBar.value = bossHealth.bossCurrentHealth;
    }
}
