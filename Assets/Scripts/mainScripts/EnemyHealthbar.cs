using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthbar : MonoBehaviour
{
    public Slider slider;
    public GameObject player;
    void Update(){
        slider.value = TutorialEnemyStats.Health;
    }
}
