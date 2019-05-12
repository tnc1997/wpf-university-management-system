namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Declares dimension specific members which each dimension service must implement.
    /// </summary>
    /// <typeparam name="TDim">The type of the dimension.</typeparam>
    public interface IDimService<TDim> : IService<TDim>
    {
    }
}