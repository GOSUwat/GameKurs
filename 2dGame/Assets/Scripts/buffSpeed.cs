using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffSpeed : MonoBehaviour
{
    public float buffDuration = 10f;
    public int buffID = 0;

    // Start is called before the first frame update
    private void Awake()
    {
    }
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        buffID = Random.Range(1, 3);
    }
    
}
