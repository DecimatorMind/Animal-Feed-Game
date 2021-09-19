using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class MatchRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float time = 5f;
    public bool flag = false;
    public void GameRestart()
    {
        if (flag == false)
        {
            flag = true;
            FindObjectOfType<ScoreResult>().ShowResult();
            ScoreResult.result = 0;
            Debug.Log("Game Over!");
            Invoke("Restart", time);
    }
}
    void Restart()
    {
        var temp = Assembly.GetAssembly(typeof(UnityEditor.Editor));
        var check = temp.GetType("UnityEditor.LogEntries");
        var mark = check.GetMethod("Clear");
        mark.Invoke(new object(), null);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
 