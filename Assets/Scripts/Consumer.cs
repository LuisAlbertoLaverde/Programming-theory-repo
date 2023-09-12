using UnityEngine;

public class Consumer : MonoBehaviour
{
    private BattleFactory _currentBattleFactory;

    public void Configure(BattleFactory battleFactory)
    {
        _currentBattleFactory = battleFactory;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F1))
        {
            _currentBattleFactory.CreateHero("Warrior");
        }
        if (Input.GetKeyUp(KeyCode.F2))
        {
            _currentBattleFactory.CreateHero("Thief");
        }
        if (Input.GetKeyUp(KeyCode.F3))
        {
            _currentBattleFactory.CreateHero("Pyromancer");
        }
        if (Input.GetKeyUp(KeyCode.F4))
        {
            _currentBattleFactory.CreateShield("EagleShield");
        }
        if (Input.GetKeyUp(KeyCode.F5))
        {
            _currentBattleFactory.CreateShield("EffigyShield");
        }
        if (Input.GetKeyUp(KeyCode.F6))
        {
            _currentBattleFactory.CreateShield("ShieldTower");
        }
        if (Input.GetKeyUp(KeyCode.F7))
        {
            _currentBattleFactory.CreateWeapon("Dagger");
        }
        if (Input.GetKeyUp(KeyCode.F8))
        {
            _currentBattleFactory.CreateWeapon("Halberds");
        }
        if (Input.GetKeyUp(KeyCode.F9))
        {
            _currentBattleFactory.CreateWeapon("LongSword");
        }
    }
}
