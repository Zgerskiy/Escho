using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route
{
    static class ConnectionHandler
    {
        public static void HandleConnection(IWin32Window window, Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch
            {
                MessageBox.Show(window, "Отсутствует подключение к базе данных", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
