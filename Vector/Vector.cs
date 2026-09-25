using System.Reflection.Metadata.Ecma335;

namespace Vector;

public struct Vector
{
    public Vector()
    {
    }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; set; }
    public double Y { get; set; }

    public double Magnitude => Math.Sqrt((X * X) + (Y * Y));

    public double Direction => Math.Atan2(Y, X) * 180/Math.PI;
    
    //methods

    public Vector Add(Vector v)
    {
        Vector result = new Vector();
        result.X = X + v.X;
        result.Y = Y + v.Y;

        return result;
    }

    public Vector Subtract(Vector v)
    {
        Vector result = new Vector();
        result.X = X - v.X;
        result.Y = Y - v.Y;

        return result;
    }

    public Vector Multiply(double scalar)
    {
        Vector result = new Vector();
        result.X = X * scalar;
        result.Y = Y * scalar;

        return result;
    }

    public Vector Divide(double scalar)
    {
        Vector result = new Vector();
        result.X = X / scalar;
        result.Y = Y / scalar;

        return result;
    }

    public double Dot(Vector v)
    {
        return (X * v.X) + (Y * v.Y);
    }
    public double AngleBetween(Vector v)
    {
        double dot = Dot(v);
        double magnitude = Magnitude * v.Magnitude;

        return Math.Acos(dot / magnitude) * 180 / Math.PI;
    }

    public Vector Normalize() 
    {
        return new Vector(X / Magnitude, Y / Magnitude);
    }

    


    public static Vector Add(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }
    public static Vector Subtract(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static Vector Multiply(Vector v, double scalar)
    {
        return v.Multiply(scalar);
    }

    public static Vector Divide(Vector v, double scalar)
    {
        return v.Divide(scalar);
    }

    public static double Dot(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static double AngleBetween(Vector v1, Vector v2)
    {
        return v1.AngleBetween(v2);
    }

    public static Vector Normalize(Vector v)
    {
        return v.Normalize();
    }


    //scaral multiplication
    public static Vector operator+(Vector v1, Vector v2)
    {
        return Vector.Add(v1, v2);
    }

    public static Vector operator-(Vector v1, Vector v2)
    {
        return Vector.Subtract(v1, v2);
    }

    //Dot product
    public static double operator*(Vector v1, Vector v2)
    {
        return Dot(v1, v2);
    }
    
    public static Vector operator *(Vector v, double scalar)
    {
        return v.Multiply(scalar);
    }

    public static Vector operator /(Vector v, double scalar)
    {
        return v.Divide(scalar);
    }

    public override string ToString()
    {
        return $"<{X}, {Y}>";
    }
}