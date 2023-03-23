using System;

using R5T.T0131;


namespace R5T.B0007.X0002
{
    [ConstantsMarker]
    public class TabCounts : IConstantsMarker
    {
        #region Infrastructure

        public static TabCounts Instance { get; } = new();

        private TabCounts()
        {
        }

        #endregion


#pragma warning disable CA1822 // Mark members as static

        [Obsolete("See R5T.Z0002.ITabCounts.TypeDeclarationTabCount")]
        public int ForTypeDeclaration => 1;
    }
}
