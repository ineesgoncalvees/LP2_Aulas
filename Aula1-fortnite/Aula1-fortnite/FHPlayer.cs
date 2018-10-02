namespace Aula1_fortnite
{
    class FHPlayer
    {
        
        private string equipedWeapon;
        private double hitPoints;
        private double shield;

        public FHPlayer()
        {
            equipedWeapon = "picareta";
            hitPoints = 100;
            shield = 0;
        }

        public FHPlayer(string equipedWeapon, double hitPoints, double shield)
        {
            this.equipedWeapon = equipedWeapon;
            this.hitPoints = hitPoints;
            this.shield = shield;
        }

        public double GetShield()
        {
            return shield;
        }

        public void SetShield(double shield)
        {
            this.shield = shield;
        }

        public void Attack(FHPlayer enemy)
        {
            enemy.TakeDamage(10);
        }

        public void TakeDamage(double damage)
        {
            if(shield > 0)
            {
                shield -= damage;

                if(shield < 0)
                {
                    shield = 0;
                }
            } else
            {
                hitPoints -= damage;
                
                if(hitPoints <= 0)
                {
                    //Die();
                }
            }
        }
    }
}
