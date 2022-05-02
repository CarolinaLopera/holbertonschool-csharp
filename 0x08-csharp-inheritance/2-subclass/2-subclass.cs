using System;

/// <sumary> class to check object </sumary>
class Obj {
        /// <sumary> mecthod to check if object
        /// is instance of subclass </sumary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType) {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}
