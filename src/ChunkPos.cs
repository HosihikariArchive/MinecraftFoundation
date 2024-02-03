using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public struct ChunkPos(int ix, int iz)
{
    internal int x = ix;
    internal int z = iz;

    public int X
    {
        readonly get => x;
        set => x = value;
    }

    public int Z
    {
        readonly get => z;
        set => z = value;
    }

    public readonly int this[ulong index] => index switch { 1 => z, _ => x };
}