using System;
using System.Collections.Generic;

namespace Text {
	/// <sumary> class of string </sumary>
	public class Str {
		/// <sumary> method to check the first time of the char unique </sumary>
		public static int UniqueChar(string s){
			Dictionary<char, bool> dict = new Dictionary<char, bool>();

			for (int i = 0; i < s.Length; i++) {
				if (dict.ContainsKey(s[i]) ) {
					dict[s[i]] = false;
				} else {
					dict[s[i]] = true;
				}
			}

			char unique = '.';
			foreach (KeyValuePair<char, bool> i in dict) {
				if (i.Value == true) {
					unique = i.Key;
					break;
				}
			}

			for (int i = 0; i < s.Length; i++) {
				if (s[i] == unique) {
					return i;
				}
			}
			return -1;
		}
	}
}
