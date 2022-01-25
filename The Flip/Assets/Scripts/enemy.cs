using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public int BonusDamage = 0;
    public int BonusDamageTaken = 0;
    public int health = 100;
    public int MaxHealth = 100;
    public Slider healthSlider;
    public Text HealthText;
    public int damage = 5;
    float AttackTimer = 0;
    bool isdead = false;
    public bool IsRange = false;
    float DeadTimer = 0;
    bool hasHoseReward = false;

    public GameObject ChooseRewards;
    private void Update()
    {
        healthSlider.value = health;
        healthSlider.maxValue = MaxHealth;
        HealthText.text = health.ToString() + "/" + MaxHealth.ToString();
        if(health<=0)
        {
            this.GetComponent<Animator>().SetInteger("AnimState",1);
            isdead = true;
            DeadTimer += Time.deltaTime;
        }
        if(DeadTimer>5f)
        {
            if(hasHoseReward==false)
            {
                ChooseRewards.SetActive(true);
                hasHoseReward = true;
            }
            
            
        }
        if(PlayerStats.IsEnemyTurn)
        {
            if(isdead)
            {
                return;
            }
            Attack();
        }
    }
    
    void Attack()
    {
        AttackTimer += Time.deltaTime;
        if(AttackTimer<2)
        {
            this.GetComponent<Animator>().SetInteger("AnimState", 2);
        }
        else
        {
            damage = Random.Range(1, 10)+BonusDamage;
            PlayerStats.TakeDamage(damage);
            this.GetComponent<Animator>().SetInteger("AnimState", 0);
            AttackTimer = 0;
            PlayerStats.IsEnemyTurn = false;
            PlayerStats.IsPlayerTurn = true;
        }
        
    }
    public void TakeDamage(int dmg)
    {
        health -= dmg;
        health -= BonusDamageTaken;
    }
}
