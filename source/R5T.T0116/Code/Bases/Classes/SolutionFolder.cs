using System;


namespace R5T.T0116
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SolutionFolder : ISolutionFolder
    {
        #region Static
        
        public static SolutionFolder Instance { get; } = new();

        #endregion
    }
}