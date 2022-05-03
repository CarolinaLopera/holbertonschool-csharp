using System;

/// <sumary> class Shape </sumary>
class Shape {
    /// <sumary> method that generate a exception </sumary>
    public virtual int Area() {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <sumary> class Rectangle inherits from Shape </sumary>
class Rectangle : Shape {
    /// <summary> privates fields width and height </summary>
    private int width;
    private int height;

    /// <summary> public property Width </summary>
    public int Width {
        get {
            return width;
        }
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");

            width = value;
        }
    }

    /// <summary> public property Height </summary>
    public int Height {
        get {
            return height;
        }
        set {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");

            height = value;
        }
    }

    /// <summary> public override that replace method Area from Shape </summary>
    public override int Area() {
        return width * height;
    }

    /// <summary> public override string that prints attributes of Rectangle </summary>
    public override string ToString() => $"[Rectangle] {width} / {height}";
}

/// <sumary> class Square </sumary>
class Square : Rectangle {

    /// <summary> privates fields size </summary>
    private int size;

    /// <summary> public property Size </summary>
    public int Size {
        get {
            return size;
        }
        set {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");

            size = value;
        }
    }
}
