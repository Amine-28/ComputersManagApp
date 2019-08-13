using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class FormConnector
    {
        
            private Form mMainForm;

            private List<Form> mConnectedForms = new List<Form>();

            private Point mMainLocation;

            public FormConnector(Form mainForm)
            {
                this.mMainForm = mainForm;
                this.mMainLocation = new Point(this.mMainForm.Location.X, this.mMainForm.Location.Y);
                this.mMainForm.LocationChanged += new EventHandler(MainForm_LocationChanged);
            }

            public void ConnectForm(Form form)
            {
                if (!this.mConnectedForms.Contains(form))
                {
                    this.mConnectedForms.Add(form);
                }
            }

            void MainForm_LocationChanged(object sender, EventArgs e)
            {
                Point relativeChange = new Point(this.mMainForm.Location.X - this.mMainLocation.X, this.mMainForm.Location.Y - this.mMainLocation.Y);
                foreach (Form form in this.mConnectedForms)
                {
                    form.Location = new Point(form.Location.X + relativeChange.X, form.Location.Y + relativeChange.Y);
                }

                this.mMainLocation = new Point(this.mMainForm.Location.X, this.mMainForm.Location.Y);
            }
        
    }
}
