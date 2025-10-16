using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public enum Difficulty { Easy = 1, Normal = 2, Hard = 3 };

public class FoodCalculator : MonoBehaviour
{
    [Header("Calculator Logic Configuration")]
    [SerializeField] private int ticksInDay = 24000;
    [SerializeField] private int foodLevel = 20;
    private int foodLevelMax = 20;
    [SerializeField] private int saturationLevel = 20;
    private int saturationLevelMax = 20;
    [SerializeField] private float exhuastionLevel = 0;
    private float exhuastionDrain = 4;

    [Header("Hunger Config Values")]
    [SerializeField]

    [Header("Player Activity Input Variables")]
    public ActivityProjection regProj;
    public ActivityProjection pvpProj;
    private float hungerADay = 0f;
    private float hungerADayPvp = 0f;

    [Header("Player Nation Input Variables")]
    public Difficulty difficulty;
    public int numOfTotalPlayers = 2;
    public int numOfPvpers = 1;

    [Header("Objects")]
    [HideInInspector] public TMP_Dropdown diff;
    [HideInInspector] public TMP_Dropdown AvgPlyrProjection;
    [HideInInspector] public TMP_Dropdown PvpPlyrProjection;
    [HideInInspector] public TMP_InputField AvgPlayers;
    [HideInInspector] public TMP_InputField PvpPlayers;

    public void Start()
    {

    }

    public void HungerCalc()
    {

    }
}
