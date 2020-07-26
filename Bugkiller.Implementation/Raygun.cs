namespace Bugkiller.Implementation
{
    public class Raygun
    {
        private int ammo = 6;

        public void FireAt(Bug bug)
        {
            if (HasAmmo())
            {
                if (bug.IsDodging())
                {
                    bug.Miss();
                }
                else
                {
                    bug.Hit();
                }
                ammo--;
            }
        }

        public void Recharge()
        {
            ammo = 4;
        }

        public bool HasAmmo()
        {
            return ammo > 0;
        }

        public int AmmoCount()
        {
            return ammo;
        }
    }
}
