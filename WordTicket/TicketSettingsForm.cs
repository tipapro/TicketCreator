using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WordTicket
{
    public partial class TicketSettingsForm : Form
    {
        public TicketSettingsForm()
        {
            InitializeComponent();
            LoadSavedSettings();
        }

        void LoadSavedSettings()
        {
            this.University.Text = Properties.Settings.Default.University;
            this.FacultyName.Text = Properties.Settings.Default.FacultyName;
            this.DepartmentAbbreviation.Text = Properties.Settings.Default.DepartmentAbbreviation;
            this.DisciplineName.Text = Properties.Settings.Default.DisciplineName;
            this.PreparationDirection.Text = Properties.Settings.Default.PreparationDirection;
            this.Course.Text = Properties.Settings.Default.Course;
            this.Groups.Text = Properties.Settings.Default.Groups;
            this.TrainingForm.Text = Properties.Settings.Default.TrainingForm;
            if (Properties.Settings.Default.Date == DateTime.MinValue ||
                Properties.Settings.Default.Date == DateTime.MaxValue)
            {
                Properties.Settings.Default.Date = DateTime.Now;
            }
            this.Date.Value = Properties.Settings.Default.Date;
            this.ProtocolNumber.Text = Properties.Settings.Default.ProtocolNumber;
            this.SignatoryPosition.Text = Properties.Settings.Default.SignatoryPosition;
            this.FacultyAbbreviation.Text = Properties.Settings.Default.FacultyAbbreviation;
            this.FullName.Text = Properties.Settings.Default.FullName;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Signature))
            {
                byte[] imageBytes = Convert.FromBase64String(Properties.Settings.Default.Signature);
                using (var stream = new MemoryStream(imageBytes))
                {
                    var signature = new Bitmap(stream);
                    this.SignatureImage.Height = signature.Height;
                    this.SignatureImage.Image = signature;
                }
            }
            this.TicketNumber.Value = Properties.Settings.Default.TicketNumber;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        private void AddSignatureBtn_Click(object sender, EventArgs e)
        {
            string signaturePath;
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Выберите изображение подписи";
                var res = fileDialog.ShowDialog();
                if (res != DialogResult.OK)
                {
                    return;
                }
                signaturePath = fileDialog.FileName;
            }
            var signature = Image.FromFile(signaturePath);
            float scale = signature.Width / 100f;
            signature = new Bitmap(signature, new Size(100, (int)(signature.Height / scale)));
            this.SignatureImage.Height = signature.Height;
            this.SignatureImage.Image = signature;
            string encoded = Convert.ToBase64String(
                (byte[])new ImageConverter().ConvertTo(signature, typeof(byte[])));
            Properties.Settings.Default.Signature = encoded;
        }

        private void DeleteSignatureBtn_Click(object sender, EventArgs e)
        {
            this.SignatureImage.Image = null;
            Properties.Settings.Default.Signature = string.Empty;
        }

        private void ShowExampleTicketBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Globals.ThisAddIn.GetTemplateTicket("По умолчанию");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.University.Text = string.Empty;
            this.FacultyName.Text = string.Empty;
            this.DepartmentAbbreviation.Text = string.Empty;
            this.DisciplineName.Text = string.Empty;
            this.PreparationDirection.Text = string.Empty;
            this.Course.Text = string.Empty;
            this.Groups.Text = string.Empty;
            this.TrainingForm.Text = string.Empty;
            this.Date.Value = DateTime.Now;
            this.ProtocolNumber.Text = string.Empty;
            this.SignatoryPosition.Text = string.Empty;
            this.FacultyAbbreviation.Text = string.Empty;
            this.FullName.Text = string.Empty;
            this.TicketNumber.Value = 1;
        }

        private void University_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.University = this.University.Text;
        }
        private void FacultyName_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FacultyName = this.FacultyName.Text;
        }
        private void DepartmentAbbreviation_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DepartmentAbbreviation = this.DepartmentAbbreviation.Text;
        }
        private void DisciplineName_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DisciplineName = this.DisciplineName.Text;
        }
        private void PreparationDirection_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PreparationDirection = this.PreparationDirection.Text;
        }
        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Course = this.Course.Text;
        }
        private void Groups_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Groups = this.Groups.Text;
        }
        private void TrainingForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TrainingForm = this.TrainingForm.Text;
        }
        private void Date_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Date = this.Date.Value;
        }
        private void ProtocolNumber_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProtocolNumber = this.ProtocolNumber.Text;
        }
        private void SignatoryPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SignatoryPosition = this.SignatoryPosition.Text;
        }
        private void FacultyAbbreviation_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FacultyAbbreviation = this.FacultyAbbreviation.Text;
        }
        private void FullName_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FullName = this.FullName.Text;
        }

        private void TicketNumber_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TicketNumber = (int)this.TicketNumber.Value;
        }
    }
}
