using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = System.Random;

public class OrbSpawner : MonoBehaviour
{
    private static List<Color> _colors = new List<Color>() {Color.black, Color.blue, Color.cyan, Color.magenta, Color.red };
    
    private Vector3 _centerPos;
    private Random _rnd = new System.Random();

    void Start()
    {
        _centerPos = new Vector3(0, 15, 0);
        InvokeRepeating(nameof(SpawnBall), 0F, 1F);
    }

    void SpawnBall()
    {
        GameObject orb = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Renderer renderer = orb.GetComponent<Renderer>();

        renderer.material.color = _colors[_rnd.Next(_colors.Count)];
        orb.gameObject.tag = "Orb";
        orb.transform.position = _centerPos;
        orb.transform.Translate(_rnd.Next(-10, 10), 0, _rnd.Next(0, 10));
        orb.transform.localScale = new Vector3(2, 2, 2);
        orb.AddComponent<OrbManager>();
    }
}
