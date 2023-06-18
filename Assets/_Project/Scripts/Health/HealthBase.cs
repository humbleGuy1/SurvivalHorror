﻿using UnityEngine;

namespace Health
{
    public abstract class HealthBase : MonoBehaviour, IHealth
    {
        [SerializeField] private int _value;

        public int Value => _value;

        public void TakeDamage(int damage)
        {
            _value -= damage;
        }
    }
}

