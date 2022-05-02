using System;

/// <sumary> class to check object </sumary>
class Obj {
    /// <sumary> mecthod to check if object is Array </sumary>
    public static bool IsInstanceOfArray(object obj) {
        if (obj is Array)
            return true;
        
        return false;
    }
}
