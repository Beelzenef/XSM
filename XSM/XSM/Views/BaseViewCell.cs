using Xamarin.Forms;

namespace XSM.Views
{
    public class BaseViewCell : ViewCell
    {
        public static readonly BindableProperty ParentContextProperty =
            BindableProperty.Create("ParentContext", typeof(object), typeof(BaseViewCell), null);

        public object ParentContext
        {
            get { return GetValue(ParentContextProperty); }
            set { SetValue(ParentContextProperty, value); }
        }
    }
}
