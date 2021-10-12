using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleScene_stage : MonoBehaviour
{
    public GameObject flower;
    public GameObject key;
    public GameObject enemy;
    public GameObject wp;
    public Renderer weapon;
    public GameObject player;

    public static bool isFlowerPicked = false;
    public static bool isKeyPicked = false;
    public static bool isEnemyDead = false;
    public static bool isWandTaken = false;
    public static bool isWandRotated = false;

    
    void Start(){
        player = GameObject.Find("Player");
        wp = GameObject.Find("Wand1");

        player.transform.position = new Vector2(-8,-1);
        GameObject.Find("Main Camera").transform.position = player.transform.position;

        weapon = wp.GetComponent<Renderer>();
        if(GameObject.FindGameObjectsWithTag("StaticTag").Length<=Statics.StaticFilesCount){
            DontDestroyOnLoad(gameObject);
        }else{  
            Destroy(gameObject);
        }

        if(SceneManager.GetActiveScene().name == "SampleScene"){
            if(isFlowerPicked)
                Destroy(flower);

            if(isKeyPicked){
                Destroy(key);
            }

            if(isEnemyDead){
                Destroy(enemy);
            }
        }
    }

}


