using Hosihikari.NativeInterop.Generation;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft.Foundation;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct Vec2
{
    internal float x;
    internal float y;

    public float X { readonly get => x; set => x = value; }
    public float Y { readonly get => y; set => y = value; }


    public Vec2(in Vector2 v)
    {
        x = v.X;
        y = v.Y;
    }

    public Vec2(float a, float b)
    {
        x = a;
        y = b;
    }

    public override readonly string ToString()
    {
        return $"{x},{y}";
    }

    public static Vec2 operator *(in Vec2 v, float num)
        => new(v.x * num, v.y * num);


    public static Vec2 operator +(in Vec2 v1, in Vec2 v2)
        => new(v1.x + v2.x, v1.y + v2.y);

    public static Vec2 operator -(in Vec2 v1, in Vec2 v2)
        => new(v1.x - v2.x, v1.y - v2.y);

    public static implicit operator Vector2(in Vec2 vec)
        => new(vec.x, vec.y);

    public static implicit operator Vec2(in Vector2 vec)
        => new(vec);
}
