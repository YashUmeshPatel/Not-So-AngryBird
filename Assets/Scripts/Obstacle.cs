using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour, IHealthManager
{
    private float _maxHealth;
    private float _currentHealth;
    
    List<Sprite> _damagePrefabs;

    public float MaxHealth { get => _maxHealth; set => _maxHealth = value; }
    public float CurrentHealth { get { return _currentHealth; } set { Mathf.Clamp(value, 0, _maxHealth); } }

    public bool IsDead => _currentHealth == 0;

    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
    }
}
