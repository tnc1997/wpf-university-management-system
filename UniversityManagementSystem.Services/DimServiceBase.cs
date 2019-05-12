namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines generic implementations for members which are shared between dimension services.
    /// </summary>
    /// <typeparam name="TDim">The type of the dimension.</typeparam>
    public abstract class DimServiceBase<TDim> : ServiceBase<TDim> where TDim : class
    {
    }
}