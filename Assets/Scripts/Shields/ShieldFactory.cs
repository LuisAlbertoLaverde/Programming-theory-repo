using UnityEngine;
namespace Shields
{
    public class ShieldFactory
    {
        private readonly ShieldsConfiguration _shieldsConfiguration;
        public ShieldFactory(ShieldsConfiguration shieldsConfiguration)
        {
            this._shieldsConfiguration = shieldsConfiguration;
        }

        public Shield Create(string id)
        {
            var shield = _shieldsConfiguration.GetShieldPrefabById(id);
            return Object.Instantiate(shield);
        }
    }
}

