namespace Hosihikari.Minecraft.Foundation.Bedrock;

public unsafe struct ErrorInfo<E>
    where E : unmanaged
{
    private E error;
    private fixed byte filler[0x30];

#pragma warning disable CS9084
    public ref E Error => ref error;
#pragma warning restore CS9084
}