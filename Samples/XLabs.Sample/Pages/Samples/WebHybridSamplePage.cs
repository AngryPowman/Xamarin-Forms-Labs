namespace XLabs.Sample.Pages.Samples
{
    using System.IO;
    using System.Reflection;
    using Forms.Controls;
    using Ioc;
    using Serialization;
    using Xamarin.Forms;

    public class WebHybridSamplePage : ContentPage
    {
        private readonly HybridWebView hybrid;
        public WebHybridSamplePage()
        {
            this.Content = this.hybrid = new HybridWebView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White
            };

            this.hybrid.RegisterCallback("dataCallback", t =>
                Device.BeginInvokeOnMainThread(() =>
                {
                    this.DisplayAlert("Data callback", t, "OK");
                })
            );

            this.hybrid.RegisterCallback("sendObject", s =>
            {
                var serializer = Resolver.Resolve<IJsonSerializer>();

                var o = serializer.Deserialize<SendObject>(s);

                this.DisplayAlert("Object", string.Format("JavaScript sent x: {0}, y: {1}", o.X, o.Y), "OK");
            });

            this.hybrid.RegisterNativeFunction("funcCallback", t => new object[] { "From Func callback: " + t });
        }

        #region Overrides of Page
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var assembly = this.GetType().GetTypeInfo().Assembly;
            using (var reader = new StreamReader(assembly.GetManifestResourceStream("XLabs.Sample.Data.WebHybridTest.html")))
            {
                var str = reader.ReadToEnd();
                this.hybrid.LoadContent(str);
            }
        }

        #endregion
    }

    public class SendObject
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}