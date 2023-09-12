using Heroes;
using Shields;
using Weapons;

public class BattleFactory
{
    private readonly HeroFactory _heroFactory;
    private readonly WeaponFactory _weaponFactory;
    private readonly ShieldFactory _shieldFactory;

    public BattleFactory(HeroFactory heroFactory, WeaponFactory weaponFactory, ShieldFactory shieldFactory)
    {
        _heroFactory = heroFactory;
        _weaponFactory = weaponFactory;
        _shieldFactory = shieldFactory;
    }

    public Hero CreateHero(string heroId)
    {
        return _heroFactory.Create(heroId);
    }

    public Weapon CreateWeapon(string weaponId)
    {
        return _weaponFactory.Create(weaponId);
    }

    public Shield CreateShield(string shieldId)
    {
        return _shieldFactory.Create(shieldId);
    }
}
