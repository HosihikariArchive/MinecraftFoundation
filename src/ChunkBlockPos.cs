using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public struct ChunkLocalHeight
{
    internal short val;

    public short Val { readonly get => val; set => val = value; }

    public ChunkLocalHeight(short v)
    {
        val = v;
    }

    public static implicit operator ChunkLocalHeight(short v) => new(v);
}

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public struct ChunkBlockPos
{
    internal byte x;
    internal byte z;
    ChunkLocalHeight y;

    public byte X { readonly get => x; set => x = value; }
    public byte Z { readonly get => z; set => z = value; }
    public ChunkLocalHeight Y { readonly get => y; set => y = value; }

    public ChunkBlockPos(byte x, short y, byte z)
    {
        this.x = x;
        this.z = z;
        this.y = new(y);
    }

    public readonly ushort ToLegacyIndex()
        => (ushort)((y.val & 0xF) + 16 * (z + 16 * x));
}
