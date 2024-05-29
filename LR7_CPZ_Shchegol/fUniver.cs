using System;
using System.Windows.Forms;

namespace LR7_CPZ_Shchegol
{
    public partial class fUniver : Form
    {
        private Univer _univer;

        public fUniver(ref Univer univer)
        {
            InitializeComponent();
            _univer = univer;

            // Ініціалізуємо текстві поля з властивостей об'єкта _univer
            txtName.Text = _univer.Name;
            txtYear.Text = _univer.FoundationYear.ToString();
            txtGraduates.Text = _univer.NumberOfGraduates.ToString();

            // Встановлюємо значення чекбоксів на основі властивостей об'єкта _univer
            chkHasDoctoralPrograms.Checked = _univer.HasDoctoralPrograms;
            chkHasSportsComplex.Checked = _univer.HasSportsComplex;
            chkHasPool.Checked = _univer.HasPool;
            chkHasTeachers.Checked = _univer.HasTeachers;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtGraduates.Text) ||
                !int.TryParse(txtYear.Text, out int foundationYear) ||
                !int.TryParse(txtGraduates.Text, out int numberOfGraduates))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.");
                return;
            }

            // Оновлюємо значення властивостей об'єкта _univer на основі введених даних з текстових полів і чекбоксів
            _univer.Name = txtName.Text;
            _univer.FoundationYear = foundationYear;
            _univer.NumberOfGraduates = numberOfGraduates;
            _univer.HasDoctoralPrograms = chkHasDoctoralPrograms.Checked;
            _univer.HasSportsComplex = chkHasSportsComplex.Checked;
            _univer.HasPool = chkHasPool.Checked;
            _univer.HasTeachers = chkHasTeachers.Checked;

            this.DialogResult = DialogResult.OK;
        }
    }
}
