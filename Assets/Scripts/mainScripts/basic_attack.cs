using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class basic_attack : MonoBehaviour
{
    public static float dmg;

    public static void Attack(GameObject player, GameObject target)
    {
        if(player.GetComponent<PlayerStats> () != null){
            dmg = PlayerStats.strength + PlayerStats.level;
            if(NextFloat(1,100)<=PlayerStats.CritRate){
                dmg+=NextFloat(1,10)* PlayerStats.CritDMG;
            }
        }else{
            dmg = TutorialEnemyStats.strength + TutorialEnemyStats.level;
            if(NextFloat(1f,100f)<=TutorialEnemyStats.CritRate){
                dmg+=NextFloat(1f,10f)* TutorialEnemyStats.CritDMG;
            }
        }

        if(target.GetComponent<PlayerStats> () != null){
            dmg -= PlayerStats.def + PlayerStats.armor;
            PlayerStats.Health -= dmg;
        }else{
            dmg -= TutorialEnemyStats.def + TutorialEnemyStats.armor;
            TutorialEnemyStats.Health -= dmg;
        }

    }

    public static float NextFloat(float min, float max)
    {
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }
}
