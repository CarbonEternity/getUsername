using System;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GetUserNameEx
{
    public partial class WinAPIClass : Form
    {
        public WinAPIClass()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Получение имени текущего пользователя
        /// <summary>
        /// Получение имени текущего пользователя.
        /// </summary>
        /// <param name="nameFormat">Формат имени из перечисления NameFormat.</param>
        /// <param name="userName">Выходной параметр — имя.пользователя</param>
        /// <param name="userNameSize">Количество символов в имени.</param>
        /// <returns></returns>
        //Подключение библиотеки secur32.dll
        [DllImport("secur32.dll", CharSet = CharSet.Auto)]
        public static extern int GetUserNameEx(int nameFormat, StringBuilder userName, ref uint userNameSize);

        /// <summary>
        /// Формат имени.
        /// </summary>
        public enum NameFormat : int
        {
            NameUnknown = 0,
            NameFullyQualifiedDN = 1,
            NameSamCompatible = 2,
            NameDisplay = 3,
            NameUniqueId = 6,
            NameCanonical = 7,
            NameUserPrincipal = 8,
            NameCanonicalEx = 9,
            NameServicePrincipal = 10,
            NameDnsDomain = 12
        };
        #endregion

        private void btnGetUserName_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder(100);
            uint size = 100;
            WinAPIClass.GetUserNameEx((int)WinAPIClass.NameFormat.NameSamCompatible, builder, ref size);
            lblGetUserName.Text = String.Format("Имя пользователя: {0}", builder.ToString());
        }
    }
}
