using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty { Easy = 1, Normal = 2, Hard = 3 };

public class FoodCalculator : MonoBehaviour
{
    [Header("Calculator Logic Configuration")]
    [SerializeField] private int ticksInDay = 24000;

    [Header("Player Activity Input Variables")]
    public ActivityProjection regProj;
    public ActivityProjection pvpProj;
    private float hungerADay = 0f;
    private float hungerADayPvp = 0f;

    [Header("Player Nation Input Variables")]
    public Difficulty difficulty;
    public int numOfTotalPlayers = 2;
    public int numOfPvpers = 1;

}
