using System;

/// <sumary> class Shape </sumary>
class Shape {
    /// <sumary> method that generate a exception </sumary>
    public virtual int Area() {
        throw new NotImplementedException("Area() is not implemented");
    }
}
