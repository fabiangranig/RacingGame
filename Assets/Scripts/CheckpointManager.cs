using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private Checkpoint[] checkpoints;

    void Start()
    {
        checkpoints = GameObject.FindObjectsOfType<Checkpoint>();
    }

    public void OnCheckpointTriggered()
    {

    }

    private bool AllCheckpointsHit()
    {
        foreach(Checkpoint checkpoint in checkpoints)
        {
            if(!checkpoint.IsChecked)
            {
                return false;
            }
        }

        return true;
    }

    private void ResetCheckpoints()
    {
        foreach (Checkpoint checkpoint in checkpoints)
        {
            checkpoint.Reset();
        }
    }
}