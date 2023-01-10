using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Social_App.DTO;
using Social_App.BUS;
namespace Social_App
{
    public partial class frmComment : Form
    {
        Post currentPost = null;
        public frmComment(Post post)
        {
            InitializeComponent();
            currentPost = post;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmComment_Load(object sender, EventArgs e)
        {

        }
    }
}
