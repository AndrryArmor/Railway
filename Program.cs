using System;
using System.Windows.Forms;

namespace GoodsOrdering
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new EnterForm());
        }

        public static DialogResult ShowMessage(string message, bool isQuestion = false)
        {
            if (string.IsNullOrEmpty(message) == true)
                throw new ArgumentException("Message cannot be empty");
            else if (isQuestion == true)
                return MessageBox.Show(message, "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                return MessageBox.Show(message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
