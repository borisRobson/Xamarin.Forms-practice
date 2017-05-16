using System;
using Xamarin.Forms;

namespace Foodie
{
    public class NumericEntryBehaviour : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }

        void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            //return if no value
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                return;
            double _;
            if (!double.TryParse(e.NewTextValue, out _))
                ((Entry)sender).Text = e.OldTextValue;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_TextChanged;
        }
    }
}
