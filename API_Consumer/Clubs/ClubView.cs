using System;
using System.Windows.Forms;
using API_Consumer.Common;

namespace API_Consumer.Clubs
{
    public partial class ClubView : InitForm
    {
        public ClubView()
        {
            InitializeComponent();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            var forma = new Clubs();
            forma.ClubName = tb_ClubName.Text;

            forma.Show();
        }

        private void tb_ClubName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnPregled_Click(sender, e);
            }
        }
    }
}
