using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route.Helpers
{
    static class BSHandler
    {
        public static void Handle(IWin32Window window, BindingSource bs, Action action)
        {
            if (bs.Count == 0)
            {
                MessageBox.Show(window, "Данное действие выполнить невозможно! Таблица пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            action?.Invoke();
        }
    }
}
