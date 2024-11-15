using AutomatizaciónDeTiendas.Formularios;

namespace AutomatizaciónDeTiendas
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.ShowDialog();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            OperadorLogin operadorLogin = new OperadorLogin();

            operadorLogin.ShowDialog();
        }
    }
}
