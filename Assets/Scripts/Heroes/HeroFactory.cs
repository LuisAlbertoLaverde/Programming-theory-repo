using UnityEngine;
namespace Heroes
{
    public class HeroFactory
    {
        private readonly HeroesConfiguration _heroesConfiguration;
        public HeroFactory(HeroesConfiguration heroesConfiguration)
        {
            this._heroesConfiguration = heroesConfiguration;
        }

        public Hero Create(string id)
        {
            var hero = _heroesConfiguration.GetHeroPrefabById(id);
            return Object.Instantiate(hero);
        }
    }
}

