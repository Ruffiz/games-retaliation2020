using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }

        else if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene("Menu");
        }

        
    }
}
