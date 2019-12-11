using UnityEngine;

namespace ObserverPattern
{
    public class AchievementSystem : Observer
    {
        // Start is called before the first frame update
        void Start()
        {
            PlayerPrefs.DeleteAll();
            foreach (var poi in FindObjectsOfType<PointOfInterest>())
            {
                poi.RegisterObserver(this);
            }
        }

        public override void OnNotify(object value, NotificationType notificationType)
        {
            if (notificationType == NotificationType.AchievementUnlocked)
            {
                string achievementKey = "achivement-" + value;
                if (PlayerPrefs.GetInt(achievementKey)==1)
                    return;
                PlayerPrefs.SetInt(achievementKey, 1);
                Debug.Log("Unlocked " + value);
            }
        }
    }

    public enum NotificationType
    {
        AchievementUnlocked
    }
}

