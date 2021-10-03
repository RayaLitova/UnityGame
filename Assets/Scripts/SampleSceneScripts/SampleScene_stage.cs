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

    
    void Start(){

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

            //enemy.enabled = isEnemyAlive;
            if(isWandTaken){
                weapon.enabled = isWandTaken;
                weapon.transform.parent = player.transform;
                weapon.transform.position = (Vector2)player.transform.position + new Vector2(0.6f, -0.3f);
                Destroy(weapon.GetComponent<BoxCollider2D>());
            }

            if(isEnemyDead){
                Destroy(enemy);
            }
        }

        if(SceneManager.GetActiveScene().name == "HouseScene"){
            if(isWandTaken){
                Destroy(GameObject.FindGameObjectsWithTag("chest")[0]);
                weapon.transform.parent = player.transform;
                weapon.transform.position = (Vector2)player.transform.position + new Vector2(0.6f, -0.3f);
                Destroy(weapon.GetComponent<BoxCollider2D>());
                weapon.enabled = true;
                weapon.transform.Rotate(new Vector2(0,180)); 
            }
        }
    }

}


