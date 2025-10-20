using DoAnCuoiKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class frmMainQuanTri : Form
    {
        private readonly Model1 _context;
        private readonly NguoiDung _nguoiDunghientai;
        public frmMainQuanTri(NguoiDung nguoiDung, Model1 context)
        {
            InitializeComponent();
        }

        private void frmMainQuanTri_Load(object sender, EventArgs e)
        {

        }
    }
}
