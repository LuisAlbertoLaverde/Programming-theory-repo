using System;
using System.Collections.Generic;
using UnityEngine;
namespace Weapons
{
    [CreateAssetMenu(menuName = "Custom/Weapons configuration")]
    public class WeaponsConfiguration : ScriptableObject
    {
        [SerializeField] private Weapon[] _weapons;
        private Dictionary<string, Weapon> _idToWeapon;

        private void Awake()
        {
            _idToWeapon = new Dictionary<string, Weapon>();
            foreach (var weapon in _weapons)
            {
                _idToWeapon.Add(weapon.Id, weapon);
            }
        }
        public Weapon GetWeaponPrefabById(string id)
        {
            if (!_idToWeapon.TryGetValue(id, out var weapon))
            {
                throw new Exception($"Weapon with id {id} does not exist");
            }
            return weapon;
        }
    }
}

