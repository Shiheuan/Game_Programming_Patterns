namespace PTv1
{
    public class Axe : Weapon
    {
        protected override void DoAttack(Target target)
        {
            target.Freeze(5);
            target.TakeDamage(1);
        }
    }

}

