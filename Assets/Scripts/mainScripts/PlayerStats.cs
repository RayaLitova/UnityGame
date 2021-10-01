using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    float MaxHealth = 100f;
    float MaxMana = 100f;

    public static float Health = 100f;
    public static float Mana = 100f;
    public static int level = 1;

    public static float strength = 10f;
    public static float intelect = 10f;

    void Start(){
        if(GameObject.FindGameObjectsWithTag("StaticTag").Length<=Statics.StaticFilesCount){
            DontDestroyOnLoad(gameObject);
        }else{  
            Destroy(gameObject);
        }
    }
}
