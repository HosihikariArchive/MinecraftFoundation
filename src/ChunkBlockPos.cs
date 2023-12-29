using System.Runtime.InteropServices;
using Hosihikari.NativeInterop.Generation;

namespace Hosihikari.Minecraft;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public struct ChunkLocalHeight(short v)
{
    internal short val = v;

    public short Val
    {
        readonly get => val;
        set => val = value;
    }

    public static implicit operator ChunkLocalHeight(short v)
    {
        return new(v);
    }
}

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public struct ChunkBlockPos(byte x, short y, byte z)
{
    internal byte x = x;
    internal byte z = z;
    internal ChunkLocalHeight y = new(y);

    public byte X
    {
        readonly get => x;
        set => x = value;
    }

    public byte Z
    {
        readonly get => z;
        set => z = value;
    }

    public ChunkLocalHeight Y
    {
        readonly get => y;
        set => y = value;
    }

    public readonly ushort ToLegacyIndex()
    {
        return (ushort)((y.val & 0xF) + 16 * (z + 16 * x));
    }
}