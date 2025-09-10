using ReaLTaiizor.Controls;

namespace Student_Information_System.Forms
{
    public partial class CourseAdd : Form
    {
        public CourseAdd()
        {
            InitializeComponent();
        }

        // Dispose
        private void btn_Back_Click(object sender, EventArgs e) => this.Close(); 

        private void btn_ConfirmAdd_Click(object sender, EventArgs e)
        {
            var result = CrownMessageBox.ShowInformation("Is this the correct information?", "Confirm Adding Course", ReaLTaiizor.Enum.Crown.DialogButton.YesNo);
        }
    }
}
