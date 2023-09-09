using System;
using System.Collections.Generic;
using UnityEngine;
namespace Heroes
{
    [CreateAssetMenu(menuName = "Custom/Heroes configuration")]
    public class HeroesConfiguration : ScriptableObject
    {
        [SerializeField] private Hero[] heroes;
        private Dictionary<string, Hero> idTohero;

        private void Awake()
        {
            idTohero = new Dictionary<string, Hero>();
            foreach (var hero in heroes)
            {
                idTohero.Add(hero.Id, hero);
            }
        }
        public Hero GetHeroPrefabById(string id)
        {
            if (!idTohero.TryGetValue(id, out var hero))
            {
                throw new Exception($"Hero with id {id} does not exist");
            }
            return hero;
        }
    }
}
