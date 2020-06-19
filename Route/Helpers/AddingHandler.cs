using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route.Helpers
{
    static class AddingHandler
    {
        public static void Handle(IWin32Window window, Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch
            {
                MessageBox.Show(window, "Проверьте введенные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
