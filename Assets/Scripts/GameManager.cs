using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //ENCAPSULATION
    public static GameManager instance { get; private set;}
    [SerializeField] float initialDelay = 0f;
    [SerializeField] float spawnInterval = 1f;
    [SerializeField] GameObject[] prefabs;
    //ENCAPSULATION
    public bool spawn { get; set;}

    //ABSTRACTION
    void SpawnRandomObject()
    {
        if (!spawn)
        {
            return;
        }
        int index = Random.Range(0, prefabs.Length);
        GameObject prefab = prefabs[index];
        Instantiate(prefab);
    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        spawn = true;
        InvokeRepeating("SpawnRandomObject", initialDelay, spawnInterval);
    }
}
