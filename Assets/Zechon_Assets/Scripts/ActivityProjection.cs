using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewActivityProjection", menuName = "Calculator/ActivityProjection")]
public class ActivityProjection : ScriptableObject
{
    [Header("Projected Amounts of Activity")]
    public int blocksWalked;
    public int blocksRan;
    public int timesJumped;
    public int timesSprintJumped;
    public int timesHit;
    public int timesHitOtherEntity;
    public int damageHealed;
    public int blocksBroken;
}
