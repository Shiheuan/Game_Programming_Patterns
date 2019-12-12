using UnityEngine;

namespace PTv2
{
    [CreateAssetMenu(menuName = "Weapon Data")]
    public class WeaponData : ScriptableObject
    {
        public int Damage;
        public string Message;
        public GameObject Model;
        public int StunDuration;
        public int FreezeDuration;
    }

}

