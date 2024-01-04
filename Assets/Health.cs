using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float _maxHealth = 100;

    private float _health;

    public Action AlteredHealth;

    public float MaxHealth => _maxHealth;
    public float HealthPoint => _health;

    private void Awake()
    {
        _health = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (_health > 0)
        {
            _health -= damage;
            AlteredHealth?.Invoke();
        }
    }

    public void TakeTreatment(float treatment)
    {
        if (_health < _maxHealth)
        {
            _health += treatment;
            AlteredHealth?.Invoke();
        }
    }
}
