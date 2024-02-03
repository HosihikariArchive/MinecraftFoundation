using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public struct SubChunkPos(int x, int y, int z)
{
    internal int x = x;
    internal int y = y;
    internal int z = z;

    public int X
    {
        get => x;
        set => x = value;
    }

    public int Y
    {
        get => y;
        set => y = value;
    }

    public int Z
    {
        get => z;
        set => z = value;
    }
}