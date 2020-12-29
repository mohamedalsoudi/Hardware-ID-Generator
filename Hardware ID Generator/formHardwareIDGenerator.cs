using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HWIDGL;

namespace Hardware_ID_Generator
{
    public partial class formHardwareIDGenerator : Form
    {
        public formHardwareIDGenerator()
        {
            InitializeComponent();
        }

        private void formHardwareIDGenerator_Load(object sender, EventArgs e)
        {
            textBoxHardwareIDGenerator.Text = HWIDGL.HWIDClass.getUniqueID("C", DateTime.Today);
        }
        
    }
    
}
