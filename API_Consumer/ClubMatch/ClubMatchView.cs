using System;
using System.Windows.Forms;
using API_Consumer.Common;

namespace API_Consumer.ClubMatch
{
    public partial class ClubMatchView : InitForm
    {
        public ClubMatchView()
        {
            InitializeComponent();
        }

        private void btn_Pregled_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Registration.Checked)
                {
                    RegistrationForm a = new RegistrationForm()
                    {
                        matchId = int.Parse(tb_matchId.Text),
                        isLive = cb_liveMatch.Checked
                    };

                    a.Show();
                } else
                {
                    ClubMatchForm _ClubMatchForm = new ClubMatchForm();
                    _ClubMatchForm.matchId = int.Parse(tb_matchId.Text);
                    _ClubMatchForm.isLive = cb_liveMatch.Checked;
                    _ClubMatchForm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Moguće je samo brojeve unijeti! Pokušajte ponovo! Ovo je greška: " + ex.Message);
            }
        }

        private void tb_matchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Pregled_Click(sender, e);
            }
        }
    }
}
