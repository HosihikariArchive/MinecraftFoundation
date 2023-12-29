using System.Text.RegularExpressions;
using Hosihikari.NativeInterop.Generation;
using Hosihikari.NativeInterop.Unmanaged;
using Hosihikari.NativeInterop.Unmanaged.STL;

namespace Hosihikari.Minecraft.Foundation.Bedrock;

public struct Result<Err>
    where Err : unmanaged
{
    public readonly bool HasValue => hasValue;

    public ref Err Error => ref error.Error;


    private ErrorInfo<Err> error;
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