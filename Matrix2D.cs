using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public class Matrix2D : IEquatable<Matrix2D>
    {
        public int A { get; init; }
        public int B { get; init; }
        public int C { get; init; }
        public int D { get; init; }
        public int Mnoznik { get; init; }
        

        public static Matrix2D Zero { get; } = new (0,0,0,0);
        public static readonly Matrix2D Id = new();

        public Matrix2D(int Mnoznik)
        {
            Mnoznik = 4;
        }
        static Matrix2D()
        {
            
        }
        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public Matrix2D() : this(1, 0, 0, 1)
        {

        }

        public override string ToString() => $"[[{A}, {B}], [{C}, {D}]]";

        public bool Equals(Matrix2D? other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return A == other.A &&
                   B == other.B &&
                   C == other.C &&
                   D == other.D;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (obj is not Matrix2D) return false;

            return Equals(obj as Matrix2D );   //(Matrix2D)obj .
        }

        public override int GetHashCode() => HashCode.Combine(A, B, C, D);

        public static bool operator == (Matrix2D? left ,Matrix2D? right)
        {
            if (ReferenceEquals(left, right)) return true; // obejmuje rowniez (null == null)
            if (left is null || right is null) return false;

            return left.Equals(right);
        }
        public static bool operator !=(Matrix2D? left, Matrix2D? right) => !(left == right);

        public static Matrix2D operator +(Matrix2D left, Matrix2D right) =>
            new(left.A + right.A,
                left.B + right.B,
                left.C + right.C,
                left.D + right.D);
        public static Matrix2D operator -(Matrix2D left, Matrix2D right) =>
            new(left.A - right.A,
                left.B - right.B,
                left.C - right.C,
                left.D - right.D);
        public static Matrix2D operator *(Matrix2D left, Matrix2D right) =>
            new(left.A * right.A + left.B * right.C,
                left.A * right.B + left.B * right.D,
                left.C * right.A + left.D * right.C,
                left.C * right.B + left.D * right.D);
        public static Matrix2D operator 

        public static Matrix2D Parse(string S)
        {
            throw new NotImplementedException();
        }
    }
}