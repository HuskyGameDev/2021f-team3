using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLight : MonoBehaviour
{
    public float minWait;
    public float maxWait;
    public GameObject light;
    private bool isSpawning;
    public GameObject[] enemies;
    public int enemy;
    public int duplicate;

    void Start()
    {
        isSpawning = false;
    }

    void Awake()
    {
        isSpawning = false;
    }

    void Update()
    {
        if (!isSpawning)
        {
            float timer = Random.Range(minWait, maxWait);
            enemy = Random.Range(0, 5);
            Invoke("SpawnObject", timer);
            isSpawning = true;
            if(enemy == duplicate)
            {
                enemy = Random.Range(0, 5);
            }
        }
    }

    void SpawnObject()
    {
        duplicate = enemy;
        Instantiate(enemies[enemy]);
        isSpawning = false;
    }
}
