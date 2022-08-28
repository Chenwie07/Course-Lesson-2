using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20; 
    int animalIndex;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0f, spawnPosZ), 
                animalPrefabs[animalIndex].transform.rotation);
            Instantiate(animalPrefabs[0], Vector3.zero, animalPrefabs[0].transform.rotation); 
        }
    }
}
