using Marriage.Models;

namespace Marriage.Components
{
    partial class GiftsSection
    {
        private List<GiftItem> gifts = new List<GiftItem>
        {
            new GiftItem {
                Icon = "fas fa-gift",
                Title = "Денежный подарок",
                Description = "Мы будем рады помощи в осуществлении нашей мечты о совместном путешествии"
            },
            new GiftItem {
                Icon = "fas fa-wine-glass-alt",
                Title = "Бутылка вина",
                Description = "Вы можете принести бутылочку хорошего вина для нашей будущей коллекции"
            },
            new GiftItem {
                Icon = "fas fa-heart",
                Title = "Ваше присутствие",
                Description = "Самый ценный подарок для нас - это разделить этот день с вами"
            }
        };
    }
}
