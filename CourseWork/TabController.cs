using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    internal class TabController
    {
        UserControl[] _tabs;
        Panel _tabView;
        public int CurrentTabId { get; private set; }

        public TabController(Panel tabView, UserControl[] tabs)
        {
            _tabs = tabs;
            _tabView = tabView;
            CurrentTabId = -1;
        }

        public void OpenTab(int index)
        {
            if (index >= _tabs.Length || index == CurrentTabId)
                return;

            _tabView.Controls.Clear();
            _tabView.Controls.Add(_tabs[index]);
            CurrentTabId = index;
        }
    }
}
