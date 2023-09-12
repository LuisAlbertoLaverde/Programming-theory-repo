using System;
using System.Collections.Generic;
using UnityEngine;
namespace Shields
{
    [CreateAssetMenu(menuName = "Custom/Shields configuration")]
    public class ShieldsConfiguration : ScriptableObject
    {
        [SerializeField] private Shield[] _shields;
        private Dictionary<string, Shield> _idToShield;

        private void Awake()
        {
            _idToShield = new Dictionary<string, Shield>();
            foreach (var shield in _shields)
            {
                _idToShield.Add(shield.Id, shield);
            }
        }
        public Shield GetShieldPrefabById(string id)
        {
            if (!_idToShield.TryGetValue(id, out var shield))
            {
                throw new Exception($"Shield with id {id} does not exist");
            }
            return shield;
        }
    }
}

