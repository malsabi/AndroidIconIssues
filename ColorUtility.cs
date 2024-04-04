namespace AndroidIconIssues
{
    public static class ColorUtility
    {
        public static readonly BindableProperty ImageColorProperty = BindableProperty.CreateAttached(
            "ImageColor",
            typeof(Color),
            typeof(ColorUtility),
            defaultValue: Colors.Black,
            propertyChanged: OnImageColorChanged);

        public static Color GetImageColor(BindableObject view)
        {
            return (Color)view.GetValue(ImageColorProperty);
        }

        public static void SetImageColor(BindableObject view, Color value)
        {
            view.SetValue(ImageColorProperty, value);
        }

        private static void OnImageColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is not View view)
                return;

            if (newValue is not Color newColor)
                return;

            if (view is Button button && button.ImageSource is FontImageSource fontIamgeSource)
                fontIamgeSource.Color = newColor;
            
        }
    }
}