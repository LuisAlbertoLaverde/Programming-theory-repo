using UnityEngine;
namespace Shields
{
    public class ShieldFactory
    {
        private readonly ShieldsConfiguration shieldsConfiguration;
        public ShieldFactory(ShieldsConfiguration shieldsConfiguration)
        {
            this.shieldsConfiguration = shieldsConfiguration;
        }

        public Shield Create(string id)
        {
            var shield = shieldsConfiguration.GetShieldPrefabById(id);
            return Object.Instantiate(shield);
        }
    }
}

