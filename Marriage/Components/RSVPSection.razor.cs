using Marriage.Models;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace Marriage.Components
{
    partial class RSVPSection
    {
        private RSVPModel rsvpModel = new();
        private bool isSubmitting = false;
        private bool showSuccessMessage = false;

        private async Task HandleSubmit()
        {
            isSubmitting = true;

            //await SendEmailViaSmtp(rsvpModel);
            await Task.Delay(1000); // Имитация задержки сети

            Console.WriteLine($"RSVP отправлено: {rsvpModel.Name}, {rsvpModel.Email}, Гостей: {rsvpModel.GuestsCount}");

            showSuccessMessage = true;
            isSubmitting = false;

            // Сброс формы через 5 секунд
            await Task.Delay(5000);
            rsvpModel = new RSVPModel();
            showSuccessMessage = false;

            StateHasChanged();
        }

        private async Task SendEmailViaSmtp(RSVPModel model)
        {
            try
            {
                string apiKey = "YOUR_SENDGRID_API_KEY";
                string fromEmail = "bozheniy1337@gmail.com";
                string toEmail = "lizhe@bk.ru";

                var client = new SendGridClient(apiKey);
                var from = new EmailAddress(fromEmail, "Сайт приглашения");
                var subject = $"Новая RSVP заявка от {model.Name}";
                var to = new EmailAddress(toEmail);

                string plainTextContent = $"Имя: {model.Name}\n" +
                                         $"Email: {model.Email}\n" +
                                         $"Гостей: {model.GuestsCount}\n" +
                                         $"Комментарий: {model.Message}";

                string htmlContent = $"<h3>Новая RSVP заявка</h3>" +
                                    $"<p><strong>Имя:</strong> {model.Name}</p>" +
                                    $"<p><strong>Email:</strong> {model.Email}</p>" +
                                    $"<p><strong>Гостей:</strong> {model.GuestsCount}</p>" +
                                    $"<p><strong>Комментарий:</strong> {model.Message ?? "Нет комментария"}</p>";

                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);

                if (response.StatusCode != System.Net.HttpStatusCode.Accepted)
                {
                    throw new Exception("Ошибка отправки email");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");

            }
            
        }
    }
}
