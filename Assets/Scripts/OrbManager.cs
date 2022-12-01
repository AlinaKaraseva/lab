using System;
using UnityEngine;

public class OrbManager : MonoBehaviour
{
    private static Color _lastColor;
    private static int _nextScore = 1;
    
    private static int _units = 1;
    
    void Update()
    {
        if (gameObject.CompareTag("Orb"))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 5);
        }
        if (gameObject.CompareTag("Orb") && transform.position.y < -8)
        {
            Destroy(this.gameObject);
            ScoreManager.AddHealth(-1);
        }
    }

    private void OnMouseDown()
    {
        if (this.gameObject.CompareTag("Background"))
        {
            ScoreManager.AddMissClicks(1);
            return;
        }
        
        if (this.gameObject.CompareTag("Orb"))
        {
            Color currentColor = this.gameObject.GetComponent<Renderer>().material.color;
            if (currentColor == _lastColor)
            {
                _units += 1;
                _nextScore = Convert.ToInt32(Math.Pow(_units, 2));
            }
            else
            {
                _units = 1;
                _nextScore = 1;
            }
            ScoreManager.AddScore(_nextScore);
            _lastColor = currentColor;
        
            Destroy(this.gameObject);
        }
    }
}
