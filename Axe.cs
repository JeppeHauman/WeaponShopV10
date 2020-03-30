namespace WeaponShopV10
{
    /// <summary>
    /// This class represents a Axe. An Axe is 
    /// considered to be a weapon.
    /// </summary>
    public class Axe : Weapon
    {
        public const int InitialAxeMinDamage = 50;
        public const int InitialAxeMaxDamage = 50;

        #region Constructor
        public Axe(string description) 
            : base(description, InitialAxeMinDamage, InitialAxeMaxDamage)
        {
        } 
        #endregion

        #region Methods
        int result;
        public int DamageFromAxe()
        {
            result = CalculateDamage();
            Desharpen();
            return result;
            
        }
        int decreaseByThree = 3;
        public void Desharpen()
        {
            MinDamage = MinDamage - decreaseByThree;
            MaxDamage = MaxDamage - decreaseByThree;
        }

        public void Sharpen()
        {
            MinDamage = InitialAxeMinDamage;
            MaxDamage = InitialAxeMaxDamage;
        }
        #endregion
    }
}