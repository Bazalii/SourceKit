using Microsoft.CodeAnalysis;

namespace SourceKit.Extensions;

public static class CompilationExtensions
{
    public static INamedTypeSymbol GetTypeSymbol<T>(this Compilation compilation)
    {
        var type = typeof(T);
        return compilation.GetTypeByMetadataName(type.FullName ?? string.Empty)
               ?? throw new ArgumentException($"Type {type} is not part of compilation");
    }

    public static INamedTypeSymbol GetTypeSymbol(this Compilation compilation, Type type)
    {
        return compilation.GetTypeByMetadataName(type.FullName ?? string.Empty)
               ?? throw new ArgumentException($"Type {type} is not part of compilation");
    }
}