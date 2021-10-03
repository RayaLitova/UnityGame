using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnemyStats : MonoBehaviour
{
    public static float Health = 100f;
    public static float strength = 3f;
    public static float CritRate = 10f;
    public static float CritDMG = 5f;
    public static int level = 1;

    public static float armor = 2;
    public static float def = 1;

    private float nextActionTime = 0f;
    private float period = 1f;

}
