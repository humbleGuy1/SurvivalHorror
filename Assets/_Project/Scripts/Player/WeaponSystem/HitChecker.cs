﻿using EnemyLogic;
using HittableObjects;
using UnityEngine;

namespace PlayerLogic.WeaponSystem
{
    public class HitChecker
    {
        public void HitEnemy(Ray ray, int damage)
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out Enemy enemy))
                {
                    enemy.Health.TakeDamage(damage);
                }
            }
        }

        public void HitHittableObject(Ray ray)
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out IHittableObject hittable))
                {
                    hittable.SpawnImpactParticles(hit);
                }
            }
        }
    }
}

