using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCutscene : MonoBehaviour {

    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading) {
            SceneManager.LoadScene("LevelOne");
        }
    }
}
