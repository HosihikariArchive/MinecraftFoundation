using Hosihikari.NativeInterop.Generation;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft.Foundation;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct Vec3
{
    internal float x;
    internal float y;
    internal float z;

    public float X { readonly get => x; set => x = value; }
    public float Y { readonly get => y; set => y = value; }
    public float Z { readonly get => z; set => z = value; }

    public Vec3(in Vector3 v)
    {
        x = v.X; y = v.Y; z = v.Z;
    }

    public Vec3(int x, int y, int z)
    {
        this.x = x; this.y = y; this.z = z;
    }

    public Vec3(float x, float y, float z)
    {
        this.x = x; this.y = y; this.z = z;
    }

    public Vec3(double x, double y, double z)
    {
        this.x = (float)x; this.y = (float)y; this.z = (float)z;
    }

    public readonly unsafe double Length => Math.Sqrt(Dot(this, this));

    public static float Dot(in Vec3 a, in Vec3 b)
        => a.y * b.y + a.x * b.x + a.z * b.z;

    public static Vec3 operator *(in Vec3 lhs, in Vec3 rhs)
        => new(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);

    public static Vec3 operator *(in Vec3 vec, float num)
        => new(vec.x * num, vec.y * num, vec.z * num);

    public static Vec3 operator /(in Vec3 lhs, in Vec3 rhs)
        => new(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);

    public static Vec3 operator /(in Vec3 vec, float num)
        => new(vec.x / num, vec.y / num, vec.z / num);

    public static Vec3 operator +(in Vec3 lhs, in Vec3 rhs)
        => new(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);

    public static Vec3 operator +(in Vec3 vec, float num)
        => new(vec.x + num, vec.y + num, vec.z + num);

    public static Vec3 operator -(in Vec3 lhs, in Vec3 rhs)
        => new(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);

    public static Vec3 operator -(in Vec3 vec, float num)
        => new(vec.x - num, vec.y - num, vec.z - num);

    public static implicit operator Vector3(in Vec3 vec)
        => new(vec.x, vec.y, vec.z);

    public static implicit operator Vec3(in Vector3 vec)
        => new(vec);
}
