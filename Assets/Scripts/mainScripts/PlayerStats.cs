using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public static float MaxHealth = 100f;
    public static float MaxMana = 100f;

    public static float Health = 100f;
    public static float Mana = 100f;
    public static int level = 1;

    public static float strength = 10f;
    public static float intelect = 10f;

    public static float CritRate = 20;
    public static float CritDMG = 5;

    public static float armor = 1;
    public static float def = 1;

    public static Dictionary<string, GameObject> inventory = new Dictionary<string, GameObject>(); 
    public static Dictionary<string, GameObject> equipment = new Dictionary<string, GameObject>(); 

    void Start(){
        if(gameObject.tag=="StaticTag"){
            if(GameObject.FindGameObjectsWithTag("StaticTag").Length<=Statics.StaticFilesCount){
                DontDestroyOnLoad(gameObject);
            }else{  
                Destroy(gameObject);
            }
        }

        if(inventory.ContainsKey("weapon")){
            strength+=inventory["weapon"].GetComponent<WeaponStats>().strength;

        }
        Debug.Log(strength);
    }
}
