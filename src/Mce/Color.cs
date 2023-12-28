
using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft.Mce;

[StructLayout(LayoutKind.Sequential)]
[PredefinedType(NativeTypeName = "Color", NativeTypeNamespace = "mce")]
public struct Color
{
    public float R;
    public float G;
    public float B;
    public float A;

    public Color(float r, float g, float b, float a)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }
}
