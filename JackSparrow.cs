namespace mis321_pa4_vinnievinchie
{
    public class JackSparrow : Character 
    {
        // Constructor for JackSparrow class
        public JackSparrow(string name) : base(name) {}
        
        //override the base class Attack method
        public override void Attack(Character opponent) {
            Console.WriteLine("{0} distracts {1}", PlayerName, opponent.PlayerName);
            opponent.Defend(AttackStrength);
        }
        
        //override the base class Defend method
        public override void Defend(int incomingDamage) {
            Health -= (int)((incomingDamage - DefensivePower) * GetBonusMultiplier(this, incomingDamage));
            Console.WriteLine("{0} takes {1} damage", PlayerName, (int)((incomingDamage - DefensivePower) * GetBonusMultiplier(this, incomingDamage)));
        }
        
        //return the bonus multiplier for an incoming attack
        private double GetBonusMultiplier(Character attacker, int incomingDamage) {
            if (attacker is WillTurner && this is JackSparrow ||
                attacker is DavyJones && this is WillTurner ||
                attacker is JackSparrow && this is DavyJones) {
                return 1.2;
            } else {
                return 1.0;
            }
        }
    }
}