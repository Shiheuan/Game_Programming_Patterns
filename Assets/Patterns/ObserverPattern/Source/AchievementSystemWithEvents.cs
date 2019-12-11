using UnityEngine;

namespace ObserverPattern
{
    public class AchievementSystemWithEvents : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            PlayerPrefs.DeleteAll();

            PointOfInterestWithEvents.OnPointOfInterestEntered += PointOfInterestWithEvents_OnPointOfInterestEntered;
        }

        private void PointOfInterestWithEvents_OnPointOfInterestEntered(PointOfInterestWithEvents poi)
        {
            string achievementKey = "achievement-" + poi.PoiName;
            if (PlayerPrefs.GetInt(achievementKey) == 1)
                return;

            PlayerPrefs.SetInt(achievementKey, 1);
            Debug.Log("Unlocked " + poi.PoiName);
        }

    }

}

