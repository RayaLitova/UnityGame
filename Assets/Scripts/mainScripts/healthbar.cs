﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public GameObject player;
    void Update(){
        player = GameObject.Find("Player");
        slider.value = PlayerStats.Health;
    }
}
