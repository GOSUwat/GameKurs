using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealingDamage : MonoBehaviour
{
    public float attackDelay = 0.1f;
    private float nextDamageEvent;
    public float attackRange = 3f;
    public float distanceToPlayer;

    Transform target;


    Healthbar hp;



    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        hp = GameObject.FindGameObjectWithTag("Player").GetComponent<Healthbar>();
        distanceToPlayer = Vector3.Distance(transform.position, target.position);
        if (distanceToPlayer <= attackRange)
        {
                hp.hp--;
                Destroy(gameObject);    
        }

        

        

        

    }

}
