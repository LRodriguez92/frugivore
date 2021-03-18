using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public List<GameObject> prefabsToSpawn;
    public float spawnHeight;
    public float spawnXPosition;
    public float spawnFrequency = 2f;

    private float counter = 0;

    void Start()
    {
        counter = 0;
    }

    void Update()
    {
        counter += Time.deltaTime;

        if (counter >= spawnFrequency)
        {
            SpawnPrefab();
            counter = 0;
        }
    }

    public void SpawnPrefab()
    {
        int index = Random.Range(0, prefabsToSpawn.Count);

        GameObject spawnedObject = Instantiate(prefabsToSpawn[index]) as GameObject;

        Vector3 spawnPosition = new Vector3();

        //Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        spawnPosition.z = prefabsToSpawn[index].transform.position.z;

        spawnPosition.y = spawnHeight;

        spawnPosition.x = Random.Range(-spawnXPosition, spawnXPosition);

        spawnedObject.transform.position = spawnPosition;
            
    }


}
