using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffs : MonoBehaviour
{
    buffSpeed _buffSpeed;
    movement  _movement;
    Healthbar hp;
    public GameObject buffPick;

    private float buffid = 0;
    private float buffDur = 0;
    private float speed = 0;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Buff")
        {
            _movement = gameObject.GetComponent<movement>();
            hp = gameObject.GetComponent<Healthbar>();
           _buffSpeed = collision.gameObject.GetComponent<buffSpeed>();
            buffDur = _buffSpeed.buffDuration;
            buffid = _buffSpeed.buffID;
            speed = _movement.movementSpeed;
            OnBuff(_buffSpeed.buffID);
               
            Destroy(collision.gameObject);
        }
    }

    private void OnGUI()
    {
            GUI.Label(new Rect(500, 15, 75, 75), "Buff time Left is " + buffDur.ToString());
            GUI.Label(new Rect(700, 15, 75, 75), "Buff type is " + buffid.ToString());
    }

    private void Update()
    {
        if(buffDur > 0)
        {
            buffDur -= Time.deltaTime;
            SpeedChange(buffDur);
        }

        
    }

    //1 speed
    //2 +hp
    void OnBuff(int x)
    {
         if (buffid == 1)
         {

            _movement.movementSpeed += 2;

            

         }

            else if (buffid == 2)
            {
                hp.hp += 2;
                buffDur = 0;
            } 

    }
    void SpeedChange(float time)
    {
        if(time <= 0)
        {
            _movement.movementSpeed = 4;
            buffDur = 0;
        }
    }
    


}
