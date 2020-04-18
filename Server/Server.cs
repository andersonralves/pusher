using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using PusherServer;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private async void Enviar()
        {
            if (String.IsNullOrEmpty(txtContratado.Text.Trim()) || String.IsNullOrEmpty(txtDemitido.Text.Trim()))
            {
                MessageBox.Show("Informe o nome do Contratado e do Demitido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var options = new PusherOptions { Cluster = "us2", Encrypted = true };

                var config = GetConfig();
                var pusher = new Pusher(config["pusher_app_id"], config["pusher_app_key"], config["pusher_app_secret"], options);

                var channel = config["pusher_app_channel"];

                await pusher.TriggerAsync(channel, "lista-contratados", new { contratado = txtContratado.Text.ToUpper() });
                await pusher.TriggerAsync(channel, "lista-demitidos", new { demitido = txtDemitido.Text.ToUpper() });

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível enviar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<string, string> GetConfig()
        {
            var configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = "Server.config";

            var config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None).AppSettings.Settings;

            var dic = new Dictionary<string, string>()
            {
                { "pusher_app_id", config["pusher_app_id"].Value },
                { "pusher_app_key", config["pusher_app_key"].Value },
                { "pusher_app_secret", config["pusher_app_secret"].Value },
                { "pusher_app_channel", config["pusher_app_channel"].Value }
            };

            return dic;           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }
    }
}
