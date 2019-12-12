using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PTv0
{
    public class Sword : MonoBehaviour
    {
        public void Attack(Target target)
        {
            target.TakeDamage(1);
            Debug.Log("You slice" + target.name);
        }
    }

}

