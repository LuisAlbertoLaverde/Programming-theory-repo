using UnityEngine;
namespace Shields
{
    public class ShieldFactory
    {
        private readonly ShieldsConfiguration shieldsConfiguration;
        public ShieldFactory(Heroes.ShieldsConfiguration heroesConfiguration)
        {
            this.shieldsConfiguration = new Shields.ShieldsConfiguration();
        }

        public Shield Create(string id)
        {
            var shield = shieldsConfiguration.GetShieldPrefabById(id);
            return Object.Instantiate(shield);
        }

    }
}

