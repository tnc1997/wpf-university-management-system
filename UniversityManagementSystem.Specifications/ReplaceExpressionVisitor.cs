using System.Linq.Expressions;

namespace UniversityManagementSystem.Specifications
{
    /// <summary>
    ///     https://stackoverflow.com/a/457328
    /// </summary>
    internal class ReplaceExpressionVisitor : ExpressionVisitor
    {
        public ReplaceExpressionVisitor(Expression oldValue, Expression newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        private Expression OldValue { get; }

        private Expression NewValue { get; }

        public override Expression Visit(Expression node)
        {
            return node == OldValue ? NewValue : base.Visit(node);
        }
    }
}