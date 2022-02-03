using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : IAudio
{
    public void PlaySound(int soundID)
    {
        // Play sound using console audio api...
        Debug.Log("Play Sound ! ID = "+soundID.ToString());
    }

    public void StopSound(int soundID)
    {
        // Stop sound using console audio api...
        Debug.Log("Stop Sound ! ID = " + soundID.ToString());
    }

    public void StopAllSounds()
    {
        // Stop all sounds using console audio api...
        Debug.Log("Stop All Sound ! ");
    }
}
