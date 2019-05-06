using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace UniversityManagementSystem.ViewModels
{
    /// <summary>
    ///     Declares generic members that each notify task completion must implement.
    /// </summary>
    /// <remarks>
    ///     This interface is used by the User Interface (UI) classes to allow the user to continue to interact with
    ///     the UI whilst asynchronous tasks are being performed in the background, otherwise the UI would freeze.
    /// </remarks>
    public interface INotifyTaskCompletion : INotifyPropertyChanged
    {
        /// <summary>
        ///     Gets the exception thrown by the task.
        /// </summary>
        AggregateException Exception { get; }

        /// <summary>
        ///     Returns true if the task is awaiting; otherwise, false.
        /// </summary>
        bool IsAwaiting { get; }

        /// <summary>
        ///     Returns true if the task is canceled; otherwise, false.
        /// </summary>
        bool IsCanceled { get; }

        /// <summary>
        ///     Returns true if the task is completed; otherwise, false.
        /// </summary>
        bool IsCompleted { get; }

        /// <summary>
        ///     Returns true if the task is faulted; otherwise, false.
        /// </summary>
        bool IsFaulted { get; }

        /// <summary>
        ///     Gets the status of the task.
        /// </summary>
        TaskStatus Status { get; }
    }

    /// <summary>
    ///     Declares generic members that each notify task completion must implement.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the task.</typeparam>
    public interface INotifyTaskCompletion<TResult> : INotifyTaskCompletion
    {
        /// <summary>
        ///     Gets the result of the task.
        /// </summary>
        TResult Result { get; }
    }
}