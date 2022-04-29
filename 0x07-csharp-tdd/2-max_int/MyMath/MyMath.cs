using System;
using System.Linq;
using System.Collections.Generic;

namespace MyMath {
    /// <sumary> class Operations </sumary>
    public class Operations {
        /// <sumary> method to return max integer in a list </sumary>
        public static int Max(List<int> nums) {
            if (nums.Count == 0) {
                return 0;
            }

            return nums.Max();
        }
    }
}
