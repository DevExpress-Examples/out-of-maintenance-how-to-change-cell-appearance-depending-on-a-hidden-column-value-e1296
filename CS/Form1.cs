using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace HowToChangeCellColor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            DataTable table = new DataTable();
            table.Columns.Add("column", typeof(string));
            table.Columns.Add("data", typeof(int));
            table.Columns.Add("hidden", typeof(int));
            table.Rows.Add("col1", 1, 2);
            table.Rows.Add("col2", 1, -2);

            pivotGridControl1.DataSource = table;
        }

        private void pivotGridControl1_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e) {
            if(e.DataField == fieldData) {
                PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
                int hiddenValue = (int)ds.GetValue(0, "hidden");
                if(hiddenValue > 0)
                    e.Appearance.BackColor = Color.Green;
                if(hiddenValue < 0)
                    e.Appearance.BackColor = Color.Red;
            }
        }
    }
}