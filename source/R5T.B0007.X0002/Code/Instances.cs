using System;


namespace R5T.B0007.X0002
{
    public static class Instances
    {
        public static B0007.ISpacingGenerator SpacingGenerator { get; } = B0007.SpacingGenerator.Instance;
        public static TabCounts TabCounts { get; } = TabCounts.Instance;
        public static B0006.ISyntaxGenerator SyntaxGenerator { get; } = B0006.SyntaxGenerator.Instance;
    }
}
