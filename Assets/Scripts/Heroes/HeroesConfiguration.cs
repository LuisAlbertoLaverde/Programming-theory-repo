using System;
using System.Collections.Generic;
using UnityEngine;
namespace Heroes
{
    [CreateAssetMenu(menuName = "Custom/Heroes configuration")]
    public class HeroesConfiguration : ScriptableObject
    {
        [SerializeField] private Hero[] _heroes;
        private Dictionary<string, Hero> _idToHero;

        private void Awake()
        {
            _idToHero = new Dictionary<string, Hero>();
            foreach (var hero in _heroes)
            {
                _idToHero.Add(hero.Id, hero);
            }
        }
        public Hero GetHeroPrefabById(string id)
        {
            if (!_idToHero.TryGetValue(id, out var hero))
            {
                throw new Exception($"Hero with id {id} does not exist");
            }
            return hero;
        }
    }
}
