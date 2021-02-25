using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class Changepage : MonoBehaviour
{
    public void SceneLoader(string scenename)
    {
       Application.LoadLevel(scenename);
    }
}
