using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int hp = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            hp--;
            if (hp >= 0)
            {
                Destroy(collision.transform.gameObject);
            }
        }
    }

}
