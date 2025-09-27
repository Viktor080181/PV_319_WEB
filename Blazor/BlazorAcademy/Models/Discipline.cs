using System.ComponentModel.DataAnnotations;  // Для [Required]

namespace BlazorAcademy.Models  // Убедитесь, что namespace совпадает с вашим проектом
{
    public class Discipline
    {
        public int Id { get; set; }  // Первичный ключ (теперь EF автоматически поймёт)

        [Required(ErrorMessage = "Название обязательно")]
        [StringLength(200, ErrorMessage = "Название не может быть длиннее 200 символов")]
        public string Name { get; set; } = string.Empty;  // Переименовал в Name для конвенций (было name)

        [StringLength(500, ErrorMessage = "Описание не может быть длиннее 500 символов")]
        public string? Description { get; set; }  // Описание (опционально)

        // Если нужна связь с учителями (одна дисциплина — много учителей), добавьте позже:
        // public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
