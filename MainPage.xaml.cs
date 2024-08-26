using OpenAI.Chat;

namespace ChatGptAPI
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var message = MessageEntry.Text;

            ChatClient client = new(model: "gpt-4o-mini-2024-07-18", "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");

            ChatCompletion completion = client.CompleteChat(message);

            ResponseText.Text = $"[ChatGPT]: {completion}";
        }
    }

}
