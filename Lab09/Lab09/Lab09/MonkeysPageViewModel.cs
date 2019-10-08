using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09
{
    public class MonkeysPageViewModel : ViewModelBase
    {
        public IList<Monkey> Monkeys => MonkeyData.Monkeys;

        Monkey selectedMonkey;
        public Monkey SelectedMonkey
        {
            get { return selectedMonkey; }
            set
            {
                if (selectedMonkey != value)
                {
                    selectedMonkey = value;
                    OnPropertyChanged();
                }
            }
        }
    }

}
