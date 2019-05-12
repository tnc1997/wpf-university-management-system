using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace UniversityManagementSystem.ViewModels
{
    /// <summary>
    ///     Defines generic implementations for members which are shared between notify task completions.
    /// </summary>
    /// <typeparam name="TResult">The type of the result returned by the task.</typeparam>
    public abstract class NotifyTaskCompletionBase<TResult> : INotifyTaskCompletion<TResult>
    {
        /// <summary>
        ///     Constructs an instance of this class with a task which returns a result.
        /// </summary>
        /// <param name="task">The task to be awaited.</param>
        protected NotifyTaskCompletionBase(Task<TResult> task)
        {
            Task = task;
        }

        /// <summary>
        ///     Gets the asynchronous task being awaited.
        /// </summary>
        protected Task<TResult> Task { get; }

        /// <inheritdoc />
        public AggregateException Exception => Task.Exception;

        /// <inheritdoc />
        public bool IsAwaiting => !Task.IsCompleted;

        /// <inheritdoc />
        public bool IsCompleted => Task.IsCompleted;

        /// <inheritdoc />
        public bool IsCanceled => Task.IsCanceled;

        /// <inheritdoc />
        public bool IsFaulted => Task.IsFaulted;

        /// <inheritdoc />
        public TaskStatus Status => Task.Status;

        /// <inheritdoc />
        public TResult Result => Status == TaskStatus.RanToCompletion ? Task.Result : default(TResult);

        /// <summary>
        ///     Fires when the status of the task has changed.
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}