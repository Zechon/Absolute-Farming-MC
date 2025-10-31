using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class Day : MonoBehaviour
{
    [Header("Tick Settings")]
    public int ticks = 24000;
    public int randomTickSpeed = 3;
    public int chunkCount = 10;
    public int sectionsPerChunk = 24;
    public int blocksPerSection = 4096;

    [Header("Simulation Info")]
    public int totalRandomTicks = 0;
    public int subChunkCount;

    [ContextMenu("Simulate Day")]
    public void SimulateFullDay()
    {
        //prepping
        totalRandomTicks = 0;
        subChunkCount = chunkCount * sectionsPerChunk;

        //running every tick
        for (int tick = 0; tick < ticks; tick++)
        {
            //running per chunk
            for (int i = 0; i < sectionsPerChunk; i++)
            {
                totalRandomTicks += randomTickSpeed;
            }
        }

        Debug.Log($"Day simulated: {totalRandomTicks} random ticks occured across {chunkCount} chunks, or {subChunkCount} sub-chunks.");
    }
}
