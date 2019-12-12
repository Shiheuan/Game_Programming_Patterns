﻿namespace PTv1
{
    public class MegaSword : Weapon
    {
        protected override void DoAttack(Target target)
        {
            target.TakeDamage(15);

            if (UnityEngine.Random.Range(0, 100) <= 30)
            {
                target.Stun(2);
            }
        }

    }

}

