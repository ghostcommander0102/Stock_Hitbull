using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashScreenController : MonoBehaviour
{
    // Start is called before the first frame update
    private float time = 0.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 3.0f)
        {
            SceneManager.LoadScene("LoginScene");
        }
    }
}
