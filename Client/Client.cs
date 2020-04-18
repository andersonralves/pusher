using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PusherClient;
using System.Configuration;
using Server;

namespace Client
{
    public partial class Client : Form
    {
        private Pusher _pusher;
        private Channel _channel;

        public Client()
        {
            InitializeComponent();

            Run();
        }

        void Run()
        {
            var connectResult = Task.Run(() => InitPusher());
            Task.WaitAll(connectResult);
        }

        private async Task InitPusher()
        {
            var options = new PusherOptions { Cluster = "us2", Encrypted = true };

            _pusher = new Pusher(ConfigurationManager.AppSettings["pusher_app_key"], options);
            _pusher.ConnectionStateChanged += _pusher_ConnectionStateChanged;
            _pusher.Error += _pusher_Error;

            _channel = _pusher.SubscribeAsync(ConfigurationManager.AppSettings["pusher_channel"]).Result;
            _channel.Subscribed += ChatChannel_Subscribed;

            _channel.Bind("lista-contratados", (dynamic data) => { setarContratados(JsonConvert.DeserializeObject(data.data.ToString())); });
            _channel.Bind("lista-demitidos", (dynamic data) => { setarDemitidos(JsonConvert.DeserializeObject(data.data.ToString())); });

            await _pusher.ConnectAsync();

        }

        void _pusher_Error(object sender, PusherException error)
        {
           MessageBox.Show("Pusher Error: " + error);
        }

        void _pusher_ConnectionStateChanged(object sender, ConnectionState state)
        {
            //MessageBox.Show("Connection state: " + state);
        }

        void ChatChannel_Subscribed(object sender)
        {
           // MessageBox.Show("Success");
        }

        void setarContratados(dynamic data)
        {
            var contratado = data.contratado.ToString();
            setarLista(lsbContratados, contratado);
        }

        void setarDemitidos(dynamic data)
        {
            var demitido = data.demitido.ToString();
            setarLista(lsbDemitidos, demitido);
        }

        void setarLista(ListBox listbox, string nome)
        {
            this.Invoke(new Action(() => { listbox.Items.Add(nome.ToUpper()); }));
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            new Server.Server().ShowDialog();
        }
    }
}
