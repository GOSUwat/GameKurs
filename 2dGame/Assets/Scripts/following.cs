using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class following : MonoBehaviour

{
    public Transform player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, -40);
    }
}
