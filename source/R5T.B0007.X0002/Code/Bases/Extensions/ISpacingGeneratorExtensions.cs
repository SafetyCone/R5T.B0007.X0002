using System;
using System.Linq;

using Microsoft.CodeAnalysis;

using R5T.B0007;

using Instances = R5T.B0007.X0002.Instances;


namespace System
{
    public static class ISpacingGeneratorExtensions
    {
        /// <summary>
        /// A blank line is two new lines in a row.
        /// </summary>
        public static SyntaxTriviaList BlankLine(this ISpacingGenerator _)
        {
            var output = Instances.SyntaxGenerator.GetNewLines_SyntaxTriviaList(2);
            return output;
        }

        public static SyntaxTriviaList ByNewLineCount(this ISpacingGenerator _,
            int newLineCount)
        {
            var output = Instances.SyntaxGenerator.GetNewLines_SyntaxTriviaList(newLineCount);
            return output;
        }

        public static SyntaxTriviaList ByTabCount(this ISpacingGenerator _,
            int tabCount)
        {
            var output = Instances.SyntaxGenerator.GetTabs_SyntaxTriviaList(tabCount);
            return output;
        }

        public static SyntaxTriviaList NewLine(this ISpacingGenerator _)
        {
            var output = Instances.SyntaxGenerator.NewLine().ToSyntaxTriviaList();
            return output;
        }

        public static SyntaxTriviaList None(this ISpacingGenerator _)
        {
            var output = new SyntaxTriviaList();
            return output;
        }

        public static SyntaxTriviaList Space(this ISpacingGenerator _)
        {
            var output = Instances.SyntaxGenerator.Space().ToSyntaxTriviaList();
            return output;
        }

        public static SyntaxTriviaList Tab(this ISpacingGenerator _)
        {
            var output = Instances.SyntaxGenerator.Tab().ToSyntaxTriviaList();
            return output;
        }

        /// <summary>
        /// Two blank lines are three new lines in a row.
        /// </summary>
        public static SyntaxTriviaList TwoBlankLines(this ISpacingGenerator _)
        {
            var output = Instances.SyntaxGenerator.GetNewLines_SyntaxTriviaList(3);
            return output;
        }
    }
}
