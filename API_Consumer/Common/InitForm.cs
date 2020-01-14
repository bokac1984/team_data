using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_Consumer.API;
using API_Consumer.Common;

namespace API_Consumer.Common
{
    public partial class InitForm : Form
    {
        /// <summary>
        /// Glavni EndPoint za Chess.com API
        /// </summary>
        public string ApiEndPoint { get; }

        public APIEndPoints api;

        public InitForm()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            CommonFunctions = new Commons();

            ApiEndPoint = Properties.Settings.Default.API_EndPoint;

            api = new APIEndPoints(ApiEndPoint);
        }
        /// <summary>
        /// Wrapper za neke osnovne funkcije
        /// </summary>
        public Commons CommonFunctions;
    }
}
