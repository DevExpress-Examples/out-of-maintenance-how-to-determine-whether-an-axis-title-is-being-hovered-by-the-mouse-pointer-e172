using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace HitTestingAxisTitle {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void chartControl1_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if (e.AdditionalObject is AxisTitle) {
                MessageBox.Show(e.AdditionalObject.GetType().ToString());
            }
            if (e.AdditionalObject is AxisLabelItem) {
                MessageBox.Show(((AxisLabelItem)e.AdditionalObject).AxisValue.ToString());
            }
        }
    }
}