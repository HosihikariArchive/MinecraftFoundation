namespace Hosihikari.Minecraft.Foundation.Bedrock;

#pragma warning disable CS9084


public unsafe struct ErrorInfo<E>
    where E : unmanaged
{
    private E error;
    private fixed byte filler[0x30];

    public ref E Error => ref error;
}
