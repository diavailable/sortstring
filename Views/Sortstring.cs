using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortstring.Views
{
    public partial class Sortstring : Form
    {
        public Sortstring()
        {
            InitializeComponent();
        }

        // Expose the input TextBox
        public TextBox InputTextBox => input;

        // Expose the ComboBox for sort options
        public ComboBox SortComboBox => selection;

        // Expose the output Label
        public Label OutputLabel => output;

        // Expose the sort Button
        public Button SortButton => sort;
    }
}
