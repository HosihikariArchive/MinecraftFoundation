using Hosihikari.NativeInterop.Generation;
using Hosihikari.NativeInterop.Unmanaged;
using Hosihikari.NativeInterop.Unmanaged.STL;
using System.Text.RegularExpressions;

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
    [GeneratedRegex("^class Bedrock::Result<void, class std::error_code>")]
    public static partial Regex ResultRegex();

    public static Regex Regex => ResultRegex();

    public static Type? Matched(Match match) => typeof(Result<StdErrorCode>);
}
