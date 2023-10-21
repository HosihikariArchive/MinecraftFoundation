using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft.Foundation;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public struct SubChunkPos
{
    internal int x;
    internal int y;
    internal int z;

    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
    public int Z { get => z; set => z = value; }

    public SubChunkPos(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}
