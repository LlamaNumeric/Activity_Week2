using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Striker : Character
{
    private float rage = 0f;

    public Striker(int maxLevel, float health = 200f, float armor = 50f, float damage = 400f)
    {
        _maxHealth = health;
        _health = health;

        _maxArmor = armor;
        _armor = armor;

        _damage = damage;

        _maxLevel = maxLevel;
    }

    public override void Attack(Character enemy)
    {
        float totalDamage = this.Damage * (1f + rage / 10f);
        enemy.TakeDamage(totalDamage);
        
        //increase rage agter every attack, when rage reach 1, reset to zero
        if (rage == 1f) rage = 0f;
        else if (rage + 0.01f < 1f) rage += 0.1f;
        else rage = 1f;
    }

    public override void TakeDamage(float damage)
    {
        _health -= _armor - damage;
        _armor -= damage / 2f;
        rage -= 0.25f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
