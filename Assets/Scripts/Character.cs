using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Character : MonoBehaviour
{
    [SerializeField] public string Name;

    protected float _maxHealth;
    protected float _health;
    protected float _maxArmor;
    protected float _armor;
    protected float _damage;
    protected float _maxLevel;
    protected int _level;
    protected float _expLevel;

    public float Health { get => _health; }
    public float Armor { get => _armor; }
    public float Damage { get => _damage; }
    protected float ExpRequirement { get => 50f * _level; }

    abstract public void Attack(Character enemy);

    abstract public void TakeDamage(float damage);

    public virtual void Heal(float amount)
    {
        _health += amount;
        if (_health > _maxHealth) _health = _maxHealth;
    }

    public void levelUp(float newExp)
    {
        _expLevel += newExp;
        if(_expLevel >= ExpRequirement)
        {
           _level++;
           _expLevel = 0;
        }
    }

    public string DebugStatus
    {
        get
        {
            return $"Name: {Name} , Health: {_health} , Armor: {_armor} , Damage: {_damage}";
        }
    }
}
