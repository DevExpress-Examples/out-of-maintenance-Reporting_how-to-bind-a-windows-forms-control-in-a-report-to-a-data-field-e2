using System.Windows.Forms;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;

namespace BindWinControl {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void winControlContainer1_BeforePrint(object sender, PrintEventArgs e) {
            Button control = ((WinControlContainer)sender).WinControl as Button;
            control.Text = GetCurrentColumnValue("CategoryName").ToString();
        }

    }
}
