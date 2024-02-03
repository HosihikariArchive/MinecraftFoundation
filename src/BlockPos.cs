using Hosihikari.NativeInterop.Generation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct BlockPos(int x, int y, int z)
{
    internal int x = x;
    internal int y = y;
    internal int z = z;

    public int X
    {
        readonly get => x;
        set => x = value;
    }

    public int Y
    {
        readonly get => y;
        set => y = value;
    }

    public int Z
    {
        readonly get => z;
        set => z = value;
    }

    private static BlockPos* MAX_ptr;

    private static BlockPos* MIN_ptr;

    private static BlockPos* ONE_ptr;

    private static BlockPos* ZERO_ptr;

    public static BlockPos MAX => *MAX_ptr;

    public static BlockPos MIN => *MIN_ptr;

    public static BlockPos ONE => *ONE_ptr;

    public static BlockPos ZERO => *ZERO_ptr;

    public override int GetHashCode()
    {
        fixed (BlockPos* pos = &this)
        {
            ulong num =
                (ulong)(((((((*(byte*)pos ^ -3750763034362895579L) * 1099511628211L) ^
                            *(byte*)((ulong)(nint)pos + 1uL)) * 1099511628211L) ^ *(byte*)((ulong)(nint)pos + 2uL)) *
                         1099511628211L) ^ *(byte*)((ulong)(nint)pos + 3uL));
            ulong num2 = 2654435769L + (num * 1099511628211L);
            ulong num3 = ((num2 >> 2) + (ulong)(172538324985L +
                                                (((((((((*(byte*)((ulong)(nint)pos + 4uL) ^ -3750763034362895579L) *
                                                        1099511628211L) ^ *(byte*)((ulong)(nint)pos + 5uL)) *
                                                      1099511628211L) ^ *(byte*)((ulong)(nint)pos + 6uL)) *
                                                    1099511628211L) ^
                                                   *(byte*)((ulong)(nint)pos + 7uL)) + (long)(num * 64)) *
                                                 1099511628211L))) ^ num2;
            return (int)(((num3 >> 2) + (ulong)(2654435769L +
                                                ((((((((*(byte*)((ulong)(nint)pos + 8uL) ^ -3750763034362895579L) *
                                                       1099511628211L) ^ *(byte*)((ulong)(nint)pos + 9uL)) *
                                                     1099511628211L) ^ *(byte*)((ulong)(nint)pos + 10uL)) *
                                                   1099511628211L) ^
                                                  *(byte*)((ulong)(nint)pos + 11uL)) * 1099511628211L) +
                                                (long)(num3 * 64))) ^ num3);
        }
    }

    public readonly double Length
    {
        get
        {
            int z = this.z;
            int y = this.y;
            int x = this.x;
            return Math.Sqrt((x * x) + (y * y) + (z * z));
        }
    }

    public ref int this[int index]
    {
        get
        {
            fixed (BlockPos* ptr = &this)
            {
                long num = (nint)ptr;
                return ref *(int*)(index switch
                {
                    2 => (nint)(num + 8),
                    1 => (nint)(num + 4),
                    _ => (nint)num
                });
            }
        }
    }

    public readonly BlockPos[] Neighbors =>
    [
        new(x, y - 1, z),
        new(x, y + 1, z),
        new(x, y, z - 1),
        new(x, y, z + 1),
        new(x - 1, y, z),
        new(x + 1, y, z)
    ];

    public BlockPos Add(int dx, int dy = 0, int dz = 0)
    {
        return new(x + dx, y + dy, z + dz);
    }

    public static bool operator ==(in BlockPos obj, in BlockPos b)
    {
        int num = (obj.x == b.x) && (obj.y == b.y) && (obj.z == b.z) ? 1 : 0;
        return (byte)num != 0;
    }

    public static bool operator !=(in BlockPos obj, in BlockPos b)
    {
        int num = (obj.x != b.x) || (obj.y != b.y) || (obj.z != b.z) ? 1 : 0;
        return (byte)num != 0;
    }

    public static BlockPos operator +(in BlockPos obj, int b)
    {
        Unsafe.SkipInit(out BlockPos result);
        result.x = obj.x + b;
        result.y = obj.y + b;
        result.z = obj.z + b;
        return result;
    }

    public static BlockPos operator +(in BlockPos obj, in BlockPos b)
    {
        Unsafe.SkipInit(out BlockPos result);
        result.x = obj.x + b.x;
        result.y = obj.y + b.y;
        result.z = obj.z + b.z;
        return result;
    }

    public static BlockPos operator *(in BlockPos obj, int b)
    {
        Unsafe.SkipInit(out BlockPos result);
        result.x = obj.x * b;
        result.y = obj.y * b;
        result.z = obj.z * b;
        return result;
    }

    public static BlockPos operator *(in BlockPos obj, in BlockPos b)
    {
        Unsafe.SkipInit(out BlockPos result);
        result.x = obj.x * b.x;
        result.y = obj.y * b.y;
        result.z = obj.z * b.z;
        return result;
    }

    public static BlockPos operator /(in BlockPos obj, int b)
    {
        Unsafe.SkipInit(out BlockPos result);
        result.x = obj.x / b;
        result.y = obj.y / b;
        result.z = obj.z / b;
        return result;
    }

    public static BlockPos operator /(in BlockPos obj, in BlockPos b)
    {
        Unsafe.SkipInit(out BlockPos result);
        result.x = obj.x / b.x;
        result.y = obj.y / b.y;
        result.z = obj.z / b.z;
        return result;
    }

    public static BlockPos operator -(in BlockPos obj, int b)
    {
        Unsafe.SkipInit(out BlockPos result);
        result.x = obj.x - b;
        result.y = obj.y - b;
        result.z = obj.z - b;
        return result;
    }

    public static BlockPos operator -(in BlockPos obj, in BlockPos b)
    {
        Unsafe.SkipInit(out BlockPos result);
        result.x = obj.x - b.x;
        result.y = obj.y - b.y;
        result.z = obj.z - b.z;
        return result;
    }

    public override readonly bool Equals(object? obj)
    {
        if (obj is BlockPos bp)
        {
            return this == bp;
        }

        return false;
    }
}