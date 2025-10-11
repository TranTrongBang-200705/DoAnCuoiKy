using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Models;

namespace DoAnCuoiKy
{
    public partial class frmDoiMK : Form
    {
        private readonly NguoiDung _nguoiDunghientai;
        private readonly Model1 _context;
        public frmDoiMK(NguoiDung nguoiDung, Model1 context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
