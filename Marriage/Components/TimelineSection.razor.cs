using Marriage.Models;

namespace Marriage.Components
{
    partial class TimelineSection
    {
        private List<TimelineItem> timelineItems = new List<TimelineItem>
        {
            new TimelineItem { Icon = "fas fa-glass-cheers", Time = "15:00", Description = "Сбор гостей, фуршет" },
            new TimelineItem { Icon = "fas fa-ring", Time = "16:30", Description = "Церемония бракосочетания" },
            new TimelineItem { Icon = "fas fa-utensils", Time = "18:00", Description = "Свадебный ужин" },
            new TimelineItem { Icon = "fas fa-music", Time = "20:00", Description = "Танцы и развлечения" }
        };
    }
}
