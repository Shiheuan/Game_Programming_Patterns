using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioPlayer audio = new AudioPlayer();
        ServiceLocator.RegisterService(audio);
    }

    // Update is called once per frame
    void Update()
    {
        //播放声音
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            var audio=ServiceLocator.GetAudioService();
            if (audio!=null)
            {
                audio.PlaySound(1);
            }
        }

        //结束声音
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            var audio = ServiceLocator.GetAudioService();
            if (audio != null)
            {
                audio.StopSound(1);
            }
        }

        //结束所有声音
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            var audio = ServiceLocator.GetAudioService();
            if (audio != null)
            {
                audio.StopAllSounds();
            }
        }

        //注册日志音频类
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ServiceLocator.EnableAudioLogging();
        }
    }
}
