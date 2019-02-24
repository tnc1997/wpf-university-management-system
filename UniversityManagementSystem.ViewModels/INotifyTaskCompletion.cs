using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace UniversityManagementSystem.ViewModels
{
    public interface INotifyTaskCompletion : INotifyPropertyChanged
    {
        AggregateException Exception { get; }

        bool IsAwaiting { get; }

        bool IsCanceled { get; }

        bool IsCompleted { get; }

        bool IsFaulted { get; }

        TaskStatus Status { get; }
    }

    public interface INotifyTaskCompletion<TResult> : INotifyTaskCompletion
    {
        TResult Result { get; }
    }
}