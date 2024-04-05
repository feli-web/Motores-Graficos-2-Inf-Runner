using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnTime;
    public GameObject spikes;
    public GameObject coin;

    public Transform[] spawnpoint;
    string[] spawnNames = { "Spawn1","Spawn2","Spawn3" };


    void Start()
    {
        InvokeRepeating("Spawning",0.0f,spawnTime);
    }
    
    void Update()
    {
        
    }
    public void Spawning()
    {
        int r = Random.Range(0, spawnNames.Length);
        Invoke(spawnNames[r], 0.0f);
    }
    public void Spawn1()
    {
        Instantiate(coin, spawnpoint[0].position, spawnpoint[0].rotation);
        Instantiate(spikes, spawnpoint[1].position, spawnpoint[1].rotation);
        Instantiate(spikes, spawnpoint[2].position, spawnpoint[2].rotation);
    } 
    public void Spawn2()
    {
        Instantiate(spikes, spawnpoint[0].position, spawnpoint[0].rotation);
        Instantiate(coin, spawnpoint[1].position, spawnpoint[1].rotation);
        Instantiate(spikes, spawnpoint[2].position, spawnpoint[2].rotation);
    }
    public void Spawn3()
    {
        Instantiate(spikes, spawnpoint[0].position, spawnpoint[0].rotation);
        Instantiate(spikes, spawnpoint[1].position, spawnpoint[1].rotation);
        Instantiate(coin, spawnpoint[2].position, spawnpoint[2].rotation);
    }
}
