using UnityEngine;
namespace Heroes
{
    public class HeroFactory
    {
        private readonly HeroesConfiguration heroesconfiguration;
        public HeroFactory(HeroesConfiguration heroesConfiguration)
        {
            this.heroesconfiguration = new HeroesConfiguration();
        }

        public Hero Create(string id)
        {
            var hero = heroesconfiguration.GetHeroPrefabById(id);
            return Object.Instantiate(hero);
        }
    }
}

