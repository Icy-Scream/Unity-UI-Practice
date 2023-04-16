using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessLoop : MonoBehaviour
{
    [SerializeField] GameObject[] _spheres;
    [SerializeField] Transform _spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var spheres in _spheres) {
            if (spheres.transform.position.y <= 0.5) {
                spheres.transform.position = new Vector3(Random.Range(0,3f),_spawnPoint.position.y,_spawnPoint.position.z);
            }
        }
    }
}
