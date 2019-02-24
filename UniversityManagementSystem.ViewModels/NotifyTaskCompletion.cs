using System.ComponentModel;
using System.Threading.Tasks;

namespace UniversityManagementSystem.ViewModels
{
    /// <summary>
    ///     https://msdn.microsoft.com/en-us/magazine/dn605875.aspx
    /// </summary>
    public class NotifyTaskCompletion<TResult> : NotifyTaskCompletionBase<TResult>
    {
        public NotifyTaskCompletion(Task<TResult> task) : base(task)
        {
            var _ = WatchTaskAsync();
        }

        public override event PropertyChangedEventHandler PropertyChanged;

        private async Task WatchTaskAsync()
        {
            if (Task.IsCompleted) return;

            try
            {
                await Task;
            }
            catch
            {
                // ignored
            }

            var propertyChanged = PropertyChanged;

            if (propertyChanged == null) return;

            propertyChanged(this, new PropertyChangedEventArgs(nameof(IsAwaiting)));
            propertyChanged(this, new PropertyChangedEventArgs(nameof(IsCompleted)));
            propertyChanged(this, new PropertyChangedEventArgs(nameof(Status)));

            if (Task.IsCanceled)
            {
                propertyChanged(this, new PropertyChangedEventArgs(nameof(IsCanceled)));
            }
            else if (Task.IsFaulted)
            {
                propertyChanged(this, new PropertyChangedEventArgs(nameof(Exception)));
                propertyChanged(this, new PropertyChangedEventArgs(nameof(IsFaulted)));
            }
            else
            {
                propertyChanged(this, new PropertyChangedEventArgs(nameof(Result)));
            }
        }
    }
}