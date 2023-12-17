using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TODO_APP
{
    public partial class main : KryptonForm
    {

        public main()
        {
            InitializeComponent();
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Load += Form1_Load;
            dataGridView1.RowValidating += dataGridView1_RowValidating;

        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Check each cell in the row except the last cell for emptiness or null
            for (int columnIndex = 0; columnIndex < row.Cells.Count - 1; columnIndex++)
            {
                DataGridViewCell cell = row.Cells[columnIndex];
                if (string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                {
                    // Display a message or perform other actions as needed
                    MessageBox.Show("Missing information.");

                    // Cancel the row validation to prevent leaving an empty row
                    e.Cancel = true;
                    break; // Stop checking further cells if one is empty
                }
            }
        }



        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonDataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DeleteSelectedRow()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No tasks to delete \nError text : " + ex.Message);
            }
            finally
            {
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
