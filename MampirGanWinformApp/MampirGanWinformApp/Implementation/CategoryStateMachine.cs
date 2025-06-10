using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using MampirGanWinformApp.StateMachine.Event;
using MampirGanWinformApp.StateMachine.State;

namespace MampirGanWinformApp.Implementation
{
    public class CategoryStateMachine
    {
        public CategoryState CurrentCategoryState { get; set; } = CategoryState.Initial;

        public static readonly Dictionary<(CategoryState, CategoryEvent), CategoryState> CategoryTransitions = new()
        {
            { (CategoryState.Initial, CategoryEvent.ViewAll), CategoryState.Viewing },
            { (CategoryState.Initial, CategoryEvent.ViewProductByCategory), CategoryState.ViewingByCategory },

            { (CategoryState.Viewing, CategoryEvent.ViewProductByCategory), CategoryState.ViewingByCategory },
            { (CategoryState.ViewingByCategory, CategoryEvent.ViewProductByCategory), CategoryState.ViewingByCategory },

            { (CategoryState.ViewingByCategory, CategoryEvent.ViewAll), CategoryState.Viewing },
            { (CategoryState.Viewing, CategoryEvent.ViewAll), CategoryState.Viewing },

            { (CategoryState.ViewingByCategory, CategoryEvent.Exit), CategoryState.Exited },
            { (CategoryState.Viewing, CategoryEvent.Exit), CategoryState.Exited },
        };

        public void HandleEventCategory(CategoryEvent CategoryEvent)
        {
            if (CategoryTransitions.TryGetValue((CurrentCategoryState, CategoryEvent), out var NextState))
            {
                CurrentCategoryState = NextState;
            }
            else
            {
                throw new InvalidOperationException($"Event Invalid {CategoryEvent} di dalam state {CurrentCategoryState}");
            }
        }
    }
}