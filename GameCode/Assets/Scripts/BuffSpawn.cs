using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpawn : MonoBehaviour
{
    public float respawnCd = 5f;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("buffSpawn", respawnCd, respawnCd);
    }

    // Update is called once per frame
    void Update()
    {


    }
    void buffSpawn()
    {
        int posX = Random.Range(-20, 20);
        int posY = Random.Range(-20, 20);
        Vector3 spawnPos = new Vector3(transform.position.x + posX, transform.position.y + posY, 0);
        Instantiate(prefab, spawnPos, Quaternion.identity);
    }
}
