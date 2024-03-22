namespace CoreHelper
{
    /// <summary>
    /// Defines the Category for the Rules based on the Step Type
    /// </summary>
    public enum Category
    {
        /// <summary>
        /// Rule is applicable for Surview, Helix and Axial
        /// </summary>
        CTStep,

        /// <summary>
        /// Rule is applicable for only Surview
        /// </summary>
        Surview,

        /// <summary>
        /// Rule is applicable for both Helix and Axial
        /// </summary>
        RotatingStep,

        /// <summary>
        /// Rule is applicable only for Axial
        /// </summary>
        Axial,

        /// <summary>
        /// Rule is applicable only for Helix
        /// </summary>
        Helix
    }
}