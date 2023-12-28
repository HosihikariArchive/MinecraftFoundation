using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft.Mce;

[StructLayout(LayoutKind.Sequential)]
[PredefinedType(NativeTypeName = "UUID", NativeTypeNamespace = "mce")]
public struct UUID
{
    public ulong A;
    public ulong B;

    public UUID(ulong a, ulong b)
    {
        A = a;
        B = b;
    }
}
