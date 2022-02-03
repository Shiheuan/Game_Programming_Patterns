using System.Collections;
using System.Collections.Generic;

public interface IAudio
{
    void PlaySound(int soundID);
    void StopSound(int soundID);
    void StopAllSounds();
}

public class NullAudio : IAudio
{
    public void PlaySound(int soundID) { /* Do nothing. */ }
    public void StopSound(int soundID) { /* Do nothing. */ }
    public void StopAllSounds() { /* Do nothing. */ }
}