using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PTv2
{
    public class WeaponTester : MonoBehaviour
    {
        [SerializeField]
        private Weapon currentWeapon;
        [SerializeField]
        private Target target;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                currentWeapon.Attack(target);
            }

        }
    }


}
