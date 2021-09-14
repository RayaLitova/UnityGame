using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour{

    public string SceneToLoad;

    private void OnCollisionEnter2D(Collision2D collision){

        if(collision.gameObject.name == "Player"){
            SceneManager.LoadScene(SceneToLoad);
        }
    }

}
