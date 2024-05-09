using Hosihikari.NativeInterop.Generation;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft;

[PredefinedType(TypeName = "class Vec2")]
[StructLayout(LayoutKind.Sequential)]
public struct Vec2(float x, float y)
{
    internal float x = x;
    internal float y = y;

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


    public Vec2(in Vector2 v) : this(v.X, v.Y)
    {
    }

    public override readonly string ToString()
    {
        return $"{x},{y}";
    }

    public static Vec2 operator *(in Vec2 v, float num)
    {
        return new(v.x * num, v.y * num);
    }


    public static Vec2 operator +(in Vec2 v1, in Vec2 v2)
    {
        return new(v1.x + v2.x, v1.y + v2.y);
    }

    public static Vec2 operator -(in Vec2 v1, in Vec2 v2)
    {
        return new(v1.x - v2.x, v1.y - v2.y);
    }

    public static implicit operator Vector2(in Vec2 vec)
    {
        return new(vec.x, vec.y);
    }

    public static implicit operator Vec2(in Vector2 vec)
    {
        return new(vec);
    }
}