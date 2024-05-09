using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft.Mce;

[StructLayout(LayoutKind.Sequential)]
[PredefinedType(TypeName = "class mce::UUID")]
public struct UUID(ulong a, ulong b)
{
    public ulong A = a;
    public ulong B = b;
}