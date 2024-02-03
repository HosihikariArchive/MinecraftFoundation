using Hosihikari.NativeInterop.Generation;
using Hosihikari.NativeInterop.Unmanaged;
using Hosihikari.NativeInterop.Unmanaged.STL;
using System.Text.RegularExpressions;

namespace Hosihikari.Minecraft.Foundation.Bedrock;

public struct Result<TErr>
    where TErr : unmanaged
{
    public readonly bool HasValue => hasValue;

    public ref TErr Error => ref _error.Error;


    private ErrorInfo<TErr> _error;
    private readonly NativeBool hasValue;
}

internal partial class ResultTypeReferencePrivider : ITypeReferenceProvider
{
    public static Regex Regex => ResultRegex();

    public static Type Matched(Match match)
    {
        return typeof(Result<StdErrorCode>);
    }

    [GeneratedRegex("^class Bedrock::Result<void, class std::error_code>")]
    public static partial Regex ResultRegex();
}