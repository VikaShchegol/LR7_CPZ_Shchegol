using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_CPZ_Shchegol
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvUniversities.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name"; column.Name = "Назва"; gvUniversities.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "FoundationYear";
            column.Name = "Рік заснування"; gvUniversities.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "NumberOfGraduates";
            column.Name = "Випускників"; gvUniversities.Columns.Add(column);

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "HasDoctoralPrograms";
            checkBoxColumn.Name = "Докторантура"; gvUniversities.Columns.Add(checkBoxColumn);

            checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "HasSportsComplex";
            checkBoxColumn.Name = "Спортивний комплекс"; gvUniversities.Columns.Add(checkBoxColumn);

            checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "HasPool";
            checkBoxColumn.Name = "Басейн"; gvUniversities.Columns.Add(checkBoxColumn);

            checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "HasTeachers";
            checkBoxColumn.Name = "Викладачі"; gvUniversities.Columns.Add(checkBoxColumn);

            bindSrcUniver.Add(new Univer("Київський національний університет", 1834, 5000, true, true, true, true));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Univer univer = new Univer();

            fUniver ft = new fUniver(ref univer);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcUniver.Add(univer);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           Univer univer = (Univer)bindSrcUniver.List[bindSrcUniver.Position];
           fUniver ft = new fUniver(ref univer);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcUniver.List[bindSrcUniver.Position] = univer;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcUniver.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcUniver.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
