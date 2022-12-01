using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int _score;
    private static int _missclicks;
    private static int _health = 3;

    public static int GetScore()
    {
        return _score;
    }

    public static int GetMissClicks()
    {
        return _missclicks;
    }

    public static int GetHealth()
    {
        return _health;
    }

    public static void AddScore(int amount)
    {
        _score += amount;
    }

    public static void AddMissClicks(int amount)
    {
        _missclicks += amount;
    }

    public static void AddHealth(int amount)
    {
        if (_health + amount >= 0)
        {
            _health += amount;
        }
    }
}
