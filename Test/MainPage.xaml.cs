namespace Test
{
    public partial class MainPage : ContentPage
    {
        LeetTranslator translator = new LeetTranslator();
        double degree;
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           string leet =  translator.ToLeet(UserEntry.Text, degree);
            if (leet != null) 
            {
                UserLbl.Text = leet;
            }
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            degree = (double)e.NewValue;
        }
    }

}
