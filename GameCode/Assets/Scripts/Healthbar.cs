using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public int hp = 5;


    private void Update()
    {
        if (hp <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
    private void OnGUI()
    {
        
        GUI.Label(new Rect(10, 15, 75, 75), "HP is " + hp.ToString());
    }
}
