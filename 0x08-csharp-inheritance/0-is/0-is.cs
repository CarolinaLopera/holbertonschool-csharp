using System;

/// <sumary> class to check object </sumary>
class Obj {
    /// <sumary> mecthod to check if object is integer </sumary>
    public static bool IsOfTypeInt(object obj) {
        if (obj.GetType() == typeof(int))
            return true;

        return false;
    }
}
