using UnityEngine;
namespace Weapons
{
    public class WeaponFactory
    {
        private readonly WeaponsConfiguration _weaponsConfiguration;
        public WeaponFactory(WeaponsConfiguration weaponsConfiguration)
        {
            this._weaponsConfiguration = weaponsConfiguration;
        }

        public Weapon Create(string id)
        {
            var weapon = _weaponsConfiguration.GetWeaponPrefabById(id);
            return Object.Instantiate(weapon);
        }
    }
}

