using UnityEngine;

// 仅支持注册音频服务的服务定位器
public class ServiceLocator
{
    static IAudio AudioService_;
    static NullAudio NullAudioService_;

    public static IAudio GetAudioService() { return AudioService_; }

    /// <summary>
    /// 注册服务
    /// </summary>
    /// <param name="service"></param>
    public static void RegisterService(IAudio service)
    {
        if (service == null)
        {
            // Revert to null service.
            AudioService_ = NullAudioService_;
        }
        else
        {
            AudioService_ = service;
        }
        Debug.Log("[ServiceLocator]Finish Register Service!");
    }

    /// <summary>
    ///  注册带日志的音频类
    /// </summary>
    public static void EnableAudioLogging()
    {
        // Decorate the existing service.
        IAudio service = new LoggedAudioPlayer(ServiceLocator.GetAudioService());

        // Swap it in.
        RegisterService(service);
    }

}
