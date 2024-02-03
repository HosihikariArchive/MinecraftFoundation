namespace Hosihikari.Minecraft.Foundation.Bedrock;

public unsafe struct ErrorInfo<TE>
    where TE : unmanaged
{
    private TE _error;
    private fixed byte _filler[0x30];

#pragma warning disable CS9084
    public ref TE Error => ref _error;
#pragma warning restore CS9084
}