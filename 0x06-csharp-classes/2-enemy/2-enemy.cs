using System;

namespace Enemies {
    /// <summary> namespace Enemies </summary>
    public class Zombie {
        /// <summary> class Zombie with constructor </summary>
        public int health;
        /// <summary> field health </summary>

        public Zombie() {
            this.health = 0;
        }
        
        /// <summary> field value = health </summary>
        public Zombie(int value) {
            this.health = value;
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}
