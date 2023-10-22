using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    public string nextSceneName = "Start";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(nextSceneName);
    }

}