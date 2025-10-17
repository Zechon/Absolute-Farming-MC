using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHunger : MonoBehaviour
{
    public float hunger = 20f;
    public float saturation = 5f;
    public float exhaustion = 0f;

    // Exhaustion amnts (Java values, Bedrock Toggle feature maybe down the line.)
    private const float EX_WALK = 0.01f;
    private const float EX_SPRINT_JUMP = 0.2f;
    private const float EX_JUMP = 0.05f;
    private const float EX_MINE = 0.005f;
    private const float EX_ATTACK = 0.1f;
    private const float EX_DAMAGE = 0.1f;
    private const float EX_HEAL = 3f;

    // This where the total exhaustion from the activity projection is figured out :P
    public float GetExhaustionFromProjection(ActivityProjection proj)
    {
        float total = 0f;
        total += proj.blocksRan * EX_WALK;
        total += proj.timesJumped * EX_JUMP;
        total += proj.timesSprintJumped * EX_SPRINT_JUMP;
        total += proj.blocksBroken * EX_MINE;
        total += proj.timesHit * EX_ATTACK;
        total += proj.timesHitOtherEntity * EX_ATTACK;
        total += proj.damageHealed * EX_HEAL;
        // Swimming value TBD (I forgor and the school blocks the wiki)
        // total += proj.blocksSwam * EX_SWIM; something like that lmao
        return total;
    }

    // Finally its time to get the hunger points lost for the day
    public int GetHungerLost(ActivityProjection proj)
    {
        float totalEx = GetExhaustionFromProjection(proj);
        int hungerLost = Mathf.FloorToInt(totalEx / 4f); // saturation ignored for now, gotta do a teensy weensy bit more double checking first
        return Mathf.Clamp(hungerLost, 0, 20);
    }
}
