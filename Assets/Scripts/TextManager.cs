using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text score;

    public Text missclicks;

    public Text health;

    void Update()
    {
        score.text = "Счет: " + ScoreManager.GetScore();
        missclicks.text = "Мисс клики: " + ScoreManager.GetMissClicks();
        health.text = "Жизни: " + ScoreManager.GetHealth() + "/3";
    }
}
