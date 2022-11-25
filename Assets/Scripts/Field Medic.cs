using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medic : Character
{
    public Medic(int maxLevel, float health = 250f, float armor = 25f, float damage = 100f)
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

    public void HealSomeone(Character selectedCharacter)
    {
        selectedCharacter.Heal(1.5f * this.Damage);
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
