using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using System;

public class Web : MonoBehaviour
{
    public static string login, password;
    private string warning;
    public static int DBscore;


    public void PasswordText(string pass)
    {
        password = pass;
    }
    public void LoginText(string log)
    {
        login = log;
    }
    // Start is called before the first frame update

    public IEnumerator Test()
    {
        WWWForm form = new WWWForm();
        form.AddField("Login", login);
        form.AddField("Password", password);
        WWW req = new WWW("siteTest.loc", form);



        yield return req;
        Debug.Log(req.text);

        //RESPOSE
        string[] mas = req.text.Split(' ');

        //Score DB
        try
        {
            DBscore = int.Parse(mas[1]);
        }


        catch(Exception )
        {

        }
        if (mas[0] == "True")
        {
            SceneManager.LoadScene(1);

        }
        else
        {
            warning = "Неправильный логин или пароль!";
        }
    }
    public void ButtonPress()
    {
        StartCoroutine(Test());
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(100, 15, 200, 200), warning);
    }

    public void OpenURL()
    {
        Application.OpenURL("http://site.loc/login.php");
    }






}
