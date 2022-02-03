using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggedAudioPlayer : IAudio
{
    IAudio wrapped_;
    public LoggedAudioPlayer(IAudio wrapped)
    {
        wrapped_ = wrapped;
    }

    public void PlaySound(int soundID)
    {
        Log("[LoggedAudio]Play sound!");
        wrapped_.PlaySound(soundID);
    }

    public void StopSound(int soundID)
    {
        Log("[LoggedAudio]Stop sound!");
        wrapped_.StopSound(soundID);
    }

    public void StopAllSounds()
    {
        Log("[LoggedAudio]Stop all sounds!");
        wrapped_.StopAllSounds();
    }

    private void Log(string message)
    {
        Debug.LogError(message);
        // Code to log message...
    }
}
