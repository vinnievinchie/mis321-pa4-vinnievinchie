namespace mis321_pa4_vinnievinchie
{
    public class WillTurner : Character 
    {
        // Constructor for Will Turner class
        public WillTurner(string name) : base(name) {}
        
        //override the base class Attack method
        public override void Attack(Character opponent) {
            Console.WriteLine("{0} attacks {1} with sword", PlayerName, opponent.PlayerName);
            opponent.Defend(AttackStrength);
        }

        //override the base class Defend method
        public override void Defend(int incomingDamage) {
            Health -= (int)((incomingDamage - DefensivePower) * GetBonusMultiplier(this, incomingDamage));
            Console.WriteLine("{0} takes {1} damage", PlayerName, (int)((incomingDamage - DefensivePower) * GetBonusMultiplier(this, incomingDamage)));
        }
        
        //return the bonus multiplier for an incoming attack
        private double GetBonusMultiplier(Character attacker, int incomingDamage) {
            if (attacker is DavyJones && this is JackSparrow ||
                attacker is JackSparrow && this is WillTurner ||
                attacker is WillTurner && this is DavyJones) {
                return 1.2;
            } else {
                return 1.0;
            }
        }
    }
}