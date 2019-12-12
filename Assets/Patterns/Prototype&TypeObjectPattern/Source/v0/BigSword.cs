using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PTv0
{
    public class BigSword : MonoBehaviour
    {
        public void Attack(Target target)
        {
            target.TakeDamage(10);
            Debug.Log("You REALLY slice" + target.name);
        }
    }

}

