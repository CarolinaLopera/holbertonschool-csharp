using System;

namespace Enemies {
    /// <summary> class Zombie </summary>
    public class Zombie {
        /// <summary> privates fields health and name </summary>
        private int health;
        private string name = "(No name)";

        /// <summary> First constructor </summary>
        public Zombie() {
            this.health = 0;
        }

        /// <summary> public property Name </summary>
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        
        /// <summary> Second constructor, value = health </summary>
        public Zombie(int value) {
            this.health = value;
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }

        /// <summary> public method of Zombie </summary>
        public int GetHealth() {
            return this.health;
        }

        /// <summary> public override string that prints attributes of Zombie </summary>
        public override string ToString() => $"Zombie Name: {name} / Total Health: {health}";
    }
}
