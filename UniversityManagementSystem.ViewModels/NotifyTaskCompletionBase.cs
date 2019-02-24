using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace UniversityManagementSystem.ViewModels
{
    public abstract class NotifyTaskCompletionBase<TResult> : INotifyTaskCompletion<TResult>
    {
        protected NotifyTaskCompletionBase(Task<TResult> task)
        {
            Task = task;
        }

        protected Task<TResult> Task { get; }

        public AggregateException Exception => Task.Exception;

        public bool IsAwaiting => !Task.IsCompleted;

        public bool IsCompleted => Task.IsCompleted;

        public bool IsCanceled => Task.IsCanceled;

        public bool IsFaulted => Task.IsFaulted;

        public TaskStatus Status => Task.Status;

        public TResult Result => Status == TaskStatus.RanToCompletion ? Task.Result : default(TResult);

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}