using UnityEngine;
namespace Heroes
{
    public class HeroFactory
    {
        private readonly ShieldsConfiguration heroesConfiguration;
        public HeroFactory(ShieldsConfiguration heroesConfiguration)
        {
            this.heroesConfiguration = new ShieldsConfiguration();
        }

        public Hero Create(string id)
        {
            var hero = heroesConfiguration.GetHeroPrefabById(id);
            return Object.Instantiate(hero);
        }
    }
}

