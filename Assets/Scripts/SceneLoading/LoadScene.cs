using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour{
    public string SceneToLoad;
    public GameObject key;
    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision){
        Statics.SceneToLoad = SceneToLoad;

        if(collision.gameObject.name == "Player"){
            if(SceneManager.GetActiveScene().name == "SampleScene" && SampleScene_stage.isKeyPicked == true)
                SceneManager.LoadSceneAsync("LoadingScreen");

            if(SceneManager.GetActiveScene().name != "SampleScene")
                SceneManager.LoadSceneAsync("LoadingScreen");

        }

    }
        
    
}
