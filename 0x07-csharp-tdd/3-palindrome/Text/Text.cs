using System;
using System.Linq;

namespace Text {
    /// <sumary> class to check palindrome
    /// (word equal to rigth and to reverse) </sumary>
    public class Str {
        /// <sumary> method to return true or false
        /// if a string is a palindrome </sumary>
        public static bool IsPalindrome(string s) {
            if (s.Length == 0) {
                return true;
            }
            s = s.ToLower();

            s = s.Replace(" ", ""); s = s.Replace(",", "");
            s = s.Replace(":", ""); s = s.Replace(".", "");
            s = s.Replace(";", ""); s = s.Replace("?", "");

            string strRev = new string(s.Reverse().ToArray());
            if (strRev == s) {
                return true;
            }
            return false;
        }
    }
}
