using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("NextScene");
    }

    public IEnumerator NextScene()
    {
        yield return new WaitForSeconds(3.27f);
        SceneManager.LoadScene("intro");
    }
}