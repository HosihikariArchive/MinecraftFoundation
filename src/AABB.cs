using Hosihikari.NativeInterop.Generation;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft;

[PredefinedType]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct AABB
{
    internal Vec3 min;
    internal Vec3 max;

    public Vec3 Min { readonly get => min; set => min = value; }
    public Vec3 Max { readonly get => max; set => max = value; }

    public unsafe ref Vec3 this[int index]
    {
        get
        {
            fixed (AABB* ptr = &this)
            {
                long num = (nint)ptr;
                return ref *(Vec3*)(index == 1 ? num + 12 : num);
            }
        }
    }
}
