using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject objectPrefab; 
    public float spawnInterval = 2f; 
    public float minX = -6f;
    public float maxX = 6f;
    public float minY = -6f;
    public float maxY = 6f;
    public int maxObjects = 149; 

    private int objectCount = 0; 

    private void Start()
    {
        InvokeRepeating("SpawnObject", spawnInterval, spawnInterval); 
    }

    private void SpawnObject()
    {
        
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        
        Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        objectCount++;

        Debug.Log("dasdasdas");
       
    }
}