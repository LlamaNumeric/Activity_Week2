using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponge : Character
{
    public Sponge(int maxLevel, float health = 500f, float armor = 100f, float damage = 250f)
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
        enemy.TakeDamage(this.Damage);
    }

    public override void TakeDamage(float damage)
    {
        _health -= _armor - damage;
        _armor -= damage / 2f;

        _armor += 0.5f;
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
