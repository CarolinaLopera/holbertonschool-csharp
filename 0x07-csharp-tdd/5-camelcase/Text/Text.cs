using System;

namespace Text {
    /// <sumary> class of string </sumary>
    public class Str {
        /// <sumary> method to count the number words in string </sumary>
        public static int CamelCase(string s) {
            if (s.Length == 0) {
                return 0;
            }
            int words = 1;

            for (int i = 0; i < s.Length; i++) {
                if (Char.IsUpper(s[i])) {
                    words++;
                }
            }
            return words;
        }
    }
}
