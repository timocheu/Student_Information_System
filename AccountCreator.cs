using Student_Information_System.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class AccountCreator : Form
    {
        public AccountCreator()
        {
            InitializeComponent();

            byte[] salt = Cryptography.GenerateSalt();
            byte[] hash = Cryptography.HashPassword("12345", salt);

            MessageBox.Show(Convert.ToBase64String(salt));
            MessageBox.Show(Convert.ToBase64String(hash));
        }
    }
}
