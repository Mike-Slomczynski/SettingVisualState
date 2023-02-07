using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingVisualState
{
    class TriggerViewModel : BindableObject
    {
        bool isToggled = true;
        public bool IsToggled
        {
            get => isToggled;
            set
            {
                isToggled = value;
                OnPropertyChanged(nameof(IsToggled));
            }
        }
    }
}
