
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace StudyWPF.ViewModels
{
    /// <summary>
    /// 
    /// 课程表 model: Master.Entities.Curricula
    ///
    /// 
    /// </summary>
    public partial class CurriculaVM: ObservableObject 
    {
        [ObservableProperty]
        private int scheduleId;
        [ObservableProperty]
        private int scheduleyId;
        [ObservableProperty]
        private DayOfWeek weekday;
        [ObservableProperty]
        private Master.Entities.Curricula?  curricula=new Master.Entities.Curricula();
    }
}
