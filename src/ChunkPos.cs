using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft.Foundation;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct ChunkPos
{
    internal int x;
    internal int z;

    public int X { readonly get => x; set => x = value; }
    public int Z { readonly get => z; set => z = value; }

    public ChunkPos(int ix, int iz)
    {
        x = ix;
        z = iz;
    }

    public readonly int this[ulong index]
        => index switch { 1 => z, _ => x };
}
