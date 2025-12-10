using System.ComponentModel.DataAnnotations;

namespace Marriage.Models
{
    public class RSVPModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите ваше имя")]
        [StringLength(50, ErrorMessage = "Имя слишком длинное")]
        public string Name { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Введите корректный email адрес")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пожалуйста, укажите количество гостей")]
        [Range(1, 10, ErrorMessage = "Количество гостей должно быть от 1 до 10")]
        public int GuestsCount { get; set; } = 2;

        public string Message { get; set; } = string.Empty;
    }
}
