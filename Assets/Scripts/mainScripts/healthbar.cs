using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public GameObject player;
    void Update(){
        if(player.GetComponent<PlayerStats> () != null){
            slider.value = PlayerStats.Health;
        }else{
            slider.value = TutorialEnemyStats.Health;
        }
    }
}
