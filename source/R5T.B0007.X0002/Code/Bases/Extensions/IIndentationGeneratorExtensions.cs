using System;

using Microsoft.CodeAnalysis;

using R5T.B0007;

using Instances = R5T.B0007.X0002.Instances;


namespace System
{
    public static class IIndentationGeneratorExtensions
    {
        [Obsolete("See R5T.Z0002.ITabCounts.ClassDeclarationTabCount")]
        public static SyntaxTriviaList ForClass(this IIndentationGenerator _)
        {
            var output = _.ForType();
            return output;
        }


        [Obsolete("See R5T.Z0002.ITabCounts.InterfaceOuterTabCount")]
        public static SyntaxTriviaList ForInterface(this IIndentationGenerator _)
        {
            var output = _.ForType();
            return output;
        }

        [Obsolete("See R5T.Z0002.ITabCounts.TypeDeclarationTabCount")]
        public static SyntaxTriviaList ForType(this IIndentationGenerator _)
        {
            var output = Instances.SpacingGenerator.ByTabCount(
                Instances.TabCounts.ForTypeDeclaration);

            return output;
        }
    }
}
