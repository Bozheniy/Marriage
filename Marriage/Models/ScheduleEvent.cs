namespace Marriage.Models
{
    public class ScheduleEvent
    {
        public string Time { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public bool IsHighlighted { get; set; } = false;
    }
}
