namespace coresearch
{
    using System.Collections.Generic;

    /// <summary>
    /// A coresearch extensions.
    /// </summary>
    public static class CoreSearchExtensions
    {
        #region Methods

        public static List<string> Query(this Coresearch s, string key)
        {
            return s.Get(key);
        }

        #endregion Methods
    }
}