using UnityEngine;

namespace PTv2
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField]
        private WeaponData weaponData;
        [SerializeField]
        private Transform weaponModelTransformParent;

        private GameObject model;

        private void OnEnable()
        {
            if (model != null)
            {
                Destroy(model);
            }

            if (weaponData.Model != null)
            {
                model = Instantiate(weaponData.Model);
                model.transform.SetParent(weaponModelTransformParent, false);
            }

        }

        public void Attack(Target target)
        {
            if (weaponData.Damage > 0)
            {
                target.TakeDamage(weaponData.Damage);
            }

            if (weaponData.StunDuration > 0)
            {
                target.Stun(weaponData.StunDuration);
            }

            if (weaponData.FreezeDuration > 0)
            {
                target.Freeze(weaponData.FreezeDuration);
            }

            string message = string.IsNullOrEmpty(weaponData.Message) ? "hit" : weaponData.Message;
            Debug.Log("You " + message + " " + target.name);
        }
    }


}
