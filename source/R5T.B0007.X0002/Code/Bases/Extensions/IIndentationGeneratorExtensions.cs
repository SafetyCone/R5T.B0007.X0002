using System;

using Microsoft.CodeAnalysis;

using R5T.B0007;

using Instances = R5T.B0007.X0002.Instances;


namespace System
{
    public static class IIndentationGeneratorExtensions
    {
        public static SyntaxTriviaList ForClass(this IIndentationGenerator _)
        {
            var output = _.ForType();
            return output;
        }

        public static SyntaxTriviaList ForInterface(this IIndentationGenerator _)
        {
            var output = _.ForType();
            return output;
        }

        public static SyntaxTriviaList ForType(this IIndentationGenerator _)
        {
            var output = Instances.SpacingGenerator.ByTabCount(
                Instances.TabCounts.ForTypeDeclaration);

            return output;
        }
    }
}
