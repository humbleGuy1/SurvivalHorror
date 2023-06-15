﻿using UnityEngine;

namespace PlayerLogic.WeaponSystem
{
    public abstract class Weapon : MonoBehaviour, IWeapon
    {
        [SerializeField] protected WeaponSO weaponSriptableObject;

        protected int maxCapacity;
        protected int currentAmmo;
        protected float fireCooldown;
        protected float reloadingTime;
        protected float cooldownTimer;
        protected bool isEmpty;

        public int MaxCapacity => maxCapacity;
        public int CurrentAmmo => currentAmmo;
        public float FireCooldown => fireCooldown;
        public float ReloadingTime => reloadingTime;
        public float CooldownTimer => cooldownTimer;
        public bool IsEmpty => isEmpty;

        public abstract void Initialize();
        public abstract void Shoot();

        public void Reload()
        {
            currentAmmo = maxCapacity;
            isEmpty = false;
        }
    }
}

