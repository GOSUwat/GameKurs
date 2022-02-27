using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
  
    public static int score = 0;
    
    public float spawnTime = 1000f;
    public GameObject prefab;
    public int hp;
  

    GameObject[] posSpawn = new GameObject[6];
    


    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
        posSpawn = GameObject.FindGameObjectsWithTag("Point");
    }
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 15, 75, 75), "Score is " + score.ToString());
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(prefab,posSpawn[Random.Range(0, 6)].GetComponent<Transform>());
    }
}
