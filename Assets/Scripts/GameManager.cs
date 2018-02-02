using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    // Use this for initialization
    private void Awake()
    {
        if(instance == null){
            instance = this;
        } else if(instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void RestartLevel(float delay){
        StartCoroutine(RestartLevelDelay(delay));
    }
    private IEnumerator RestartLevelDelay(float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Game");
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
