using Heroes;
using Shields;
using UnityEngine;
using Weapons;

public class GameInstaller : MonoBehaviour
{
    [SerializeField] private HeroesConfiguration _heroesConfiguration;
    [SerializeField] private WeaponsConfiguration _weaponsConfiguration;
    [SerializeField] private ShieldsConfiguration _shieldsConfiguration;


    private void Start()
    {
        var heroFactory = new HeroFactory(Instantiate(_heroesConfiguration));
        var weaponFactory = new WeaponFactory(Instantiate(_weaponsConfiguration));
        var shieldFactory = new ShieldFactory(Instantiate(_shieldsConfiguration));

        var consumerGameObject = new GameObject();
        var consumer = consumerGameObject.AddComponent<Consumer>();
        consumer.Configure(new BattleFactory(heroFactory, weaponFactory, shieldFactory));
    }
}
