using System.Numerics;
using System.Runtime.InteropServices;
using Hosihikari.NativeInterop.Generation;

namespace Hosihikari.Minecraft;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public struct Vec3(float x, float y, float z)
{
    internal float x = x;
    internal float y = y;
    internal float z = z;

    public float X
    {
        readonly get => x;
        set => x = value;
    }

    public float Y
    {
        readonly get => y;
        set => y = value;
    }

    public float Z
    {
        readonly get => z;
        set => z = value;
    }

    public Vec3(in Vector3 v) : this(v.X, v.Y, v.Z)
    {
    }

    public Vec3(int x, int y, int z) : this(x, y, (float)z)
    {
    }

    public Vec3(double x, double y, double z) : this((float)x, (float)y, (float)z)
    {
    }

    public readonly double Length => Math.Sqrt(Dot(this, this));

    public static float Dot(in Vec3 a, in Vec3 b)
    {
        return a.y * b.y + a.x * b.x + a.z * b.z;
    }

    public static Vec3 operator *(in Vec3 lhs, in Vec3 rhs)
    {
        return new(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
    }

    public static Vec3 operator *(in Vec3 vec, float num)
    {
        return new(vec.x * num, vec.y * num, vec.z * num);
    }

    public static Vec3 operator /(in Vec3 lhs, in Vec3 rhs)
    {
        return new(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
    }

    public static Vec3 operator /(in Vec3 vec, float num)
    {
        return new(vec.x / num, vec.y / num, vec.z / num);
    }

    public static Vec3 operator +(in Vec3 lhs, in Vec3 rhs)
    {
        return new(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
    }

    public static Vec3 operator +(in Vec3 vec, float num)
    {
        return new(vec.x + num, vec.y + num, vec.z + num);
    }

    public static Vec3 operator -(in Vec3 lhs, in Vec3 rhs)
    {
        return new(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
    }

    public static Vec3 operator -(in Vec3 vec, float num)
    {
        return new(vec.x - num, vec.y - num, vec.z - num);
    }

    public static implicit operator Vector3(in Vec3 vec)
    {
        return new(vec.x, vec.y, vec.z);
    }

    public static implicit operator Vec3(in Vector3 vec)
    {
        return new(vec);
    }
}