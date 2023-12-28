using Hosihikari.NativeInterop.Generation;
using Hosihikari.NativeInterop.Unmanaged.STL;
using System.Runtime.InteropServices;

namespace Hosihikari.Minecraft;

//[PredefinedType]
//[StructLayout(LayoutKind.Sequential)]
//public unsafe struct ReadOnlyBinaryStream
//{
//    static ReadOnlyBinaryStream(){ if (sizeof(ReadOnlyBinaryStream) is not 64) throw new AccessViolationException(); }

//    private readonly void* vtable;

//    public ulong readPointer;

//    [MarshalAs(UnmanagedType.U1)]
//    public bool unk;

//    public StdString ownBuf;
//    public StdString* pBuf;

//    public ReadOnlyBinaryStream() => throw new InvalidOperationException();
//}

//[PredefinedType]
//[StructLayout(LayoutKind.Sequential)]
//public unsafe struct BinaryStream
//{
//    static BinaryStream() { if (sizeof(BinaryStream) is not 104) throw new AccessViolationException(); }

//    public ReadOnlyBinaryStream @base;

//    public StdString writeBuf;
//    public StdString* pwBuf;

//    public BinaryStream() => throw new InvalidOperationException();
//}
