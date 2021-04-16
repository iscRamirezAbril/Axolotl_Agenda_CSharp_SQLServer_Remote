using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; // Librería que permite utilizar librerías nativas del sistema operativo.
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // Librería #1 para el envío de correos electrónicos.
using System.Net.Mail; // Librería #2 para el envío de correos electrónicos.

namespace ProyectoFinal
{
    public partial class ForgotPassword : Form {
        public ForgotPassword() {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // <--------------------------------------> //
        // <---------- EVENTOS / EVENTS ----------> //
        // <--------------------------------------> //

        // <--- Evento #1: "Enter". ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtEmail_Enter(object sender, EventArgs e) {
            if (txtEmail.Text == "EMAIL") {
                txtEmail.Text = ""; // Texto a mostrar.
                txtEmail.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #2: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtEmail_Leave(object sender, EventArgs e) {
            if (txtEmail.Text == "") {
                txtEmail.Text = "EMAIL"; // Texto a mostrar.
                txtEmail.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #3: "Enter". ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtEmailPass_Enter(object sender, EventArgs e) {
            if (txtEmailPass.Text == "EMAIL PASSWORD") {
                txtEmailPass.Text = ""; // Texto a mostrar.
                txtEmailPass.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
                txtEmailPass.UseSystemPasswordChar = true; // Esta condición permite que la contraseña no se visualice.
            }
        }

        // <--- Evento #4: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtEmailPass_Leave(object sender, EventArgs e) {
            if (txtEmailPass.Text == "") {
                txtEmailPass.Text = "EMAIL PASSWORD"; // Texto a mostrar.
                txtEmailPass.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
                txtEmailPass.UseSystemPasswordChar = false; // Esta condición permite que la contraseña se visualice.
            }
        }

        // <--- Evento #5: "MouseDown". ---> //
        /*
          Este evento nos permitirá mover el formulario desde el panel.
        */
        private void panelLogo_MouseDown(object sender, MouseEventArgs e) {
            // Llamada a los métodos.
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // <--- Evento #6: "MouseDown". ---> //
        /*
          Este evento nos permitirá mover el formulario desde el panel.
        */
        private void ForgotPassword_MouseDown(object sender, MouseEventArgs e) {
            // Llamada a los métodos.
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // <--- Evento #7: "Enter". ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtUsername_Enter(object sender, EventArgs e){
            if (txtUsername.Text == "USERNAME"){
                txtUsername.Text = ""; // Texto a mostrar.
                txtUsername.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #8: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtUsername_Leave(object sender, EventArgs e){
            if (txtUsername.Text == ""){
                txtUsername.Text = "USERNAME"; // Texto a mostrar.
                txtUsername.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "btnClose". ---> //
        private void btnClose_Click(object sender, EventArgs e) {
            /* 
               Condición que sólo funcionará sí y sólo sí el usuario presiona el botón de
               "YES" del MessageBox.
            */
            if (MessageBox.Show("¿Seguro que quiere volver a la pantalla principal? \n¡Si no mandó solicitud para recuperar su contraseña, tendrá que solicitarla de nuevo!", "¡Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Login LoginForm = new Login(); // Creación de un objeto de la clase "Login".
                LoginForm.Show(); // ".Show()" permitirá mostrar el formulario de inicio de sesión.
                this.Hide(); // ".Hide() ocultará el formulario actual (RegistrerUsers).
            }
        }

        // <--- Botón "btnMinimize". ---> //
        private void btnMinimize_Click(object sender, EventArgs e){
            this.WindowState = FormWindowState.Minimized; // Permite minimizar la ventana.
        }

        // <--- Botón "btnRecover". ---> //
        private void btnRecover_Click(object sender, EventArgs e){
            // Declaración de variables
            /*
               Los datos ingresados por el usuario en los textbox se asignarán a as variables corres´pondientes.
            */
            string email = txtEmail.Text;
            string emailpass = txtEmailPass.Text;
            string username = txtUsername.Text;

            try{
                Control ctrl = new Control(); // Creación de un objeto de la clase "Control".

                /*
                   Declaración de una variable de tipo "string" que almacenará la respuesta generada por el método
                   "ctrRecoverPassword()".
                */
                string errorMessage = ctrl.ctrlRecoverPassword(username, email, emailpass);
                                             // MessageBox que se mostrará si se prresenta algún error.
                if (errorMessage.Length > 0) MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else{
                    // INICIO DE INSTRUCCIONES PARA EL FEEDBACK QUE RECIBIRÁ "el correo del usuario@gmail.com".
                    // Se crea un objeto de la clase "MailMessage".
                    MailMessage mail = new MailMessage();
                    // Se crea un objeto de la clase "SmtpClient". Dentro de los paréntesis se escribe el "smtp" correspondiente a la compañía de correo.
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    /*
                    var fromAddress = new MailAddress("axolotlagenda.helpusers@gmail.com", "Axolotl Agenda");
                    var toAdress = new MailAddress(email, username);
                    const string fromPassword = "kueuhrvtvfjefufs";
                    const string subject = "[AxoltlAgenda] Recuperación de contraseña.";

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };

                    using (var message = new MailMessage(fromAddress, toAdress)
                    {
                        Subject = subject,
                        Body = "Usted a solicitado recuperar su contraseña." +
                        "\nLa contraseña para su inicio de sesión es: " + Session.password +
                        "\nLe recomendamos que guarde su contraseña en un lugar seguro y fácil de recordar." +
                        "\n\nAtte. Axolotl Team Support."
                    })
                    {
                        smtp.Send(message);
                    }
                    */
                    // Se crea un objeto de la clase "Smtp". Dentro de los paréntesis se escribe el "smtp" correspondiente a la compañía de correo.
                    // SmtpClient SmtpServerCopy = new SmtpClient("smtp.gmail.com");

                    mail.To.Add(txtEmail.Text); // Correo que va a recibir la contraseña.
                    mail.From = new MailAddress("axolotlagenda.helpusers@gmail.com", "Axolotl Agenda");
                    mail.Subject = "PASSWORD RECOVERY."; // "Asunto" del correo.

                    // Cuerpo del correo.
                    mail.Body = "Usted a solicitado recuperar su contraseña." +
                        "\nLa contraseña para su inicio de sesión es: " + Session.password +
                        "\nLe recomendamos que guarde su contraseña en un lugar seguro y fácil de recordar." +
                        "\n\nAtte. Axolotl Team Support.";
                    // FIN //

                    // Este bloque de código servirá para dar credenciales al correo electrónico del usuario.
                    // INICIO //
                    SmtpServer.Port = 587; // Puerto.
                    SmtpServer.EnableSsl = true; // Habilitar "uso de aplicaciones poco seguras" para el correo del usuario.
                    // Asignación de credenciales del correo de soporte. Se pide el correo y contraseña del mismo.
                    SmtpServer.Credentials = new NetworkCredential("Axolotlteam.helpusers@gmail.com", "kueuhrvtvfjefufs");
                    
                    SmtpServer.Send(mail); // ".Send() es el método que permitirá mandar el mensaje.
                    // FIN //
                    // FIN DEL BLOQUE DE CÓDIGO DE INSTRUCCIONES DEL FEEDBACK QUE RECIBIRÁ "coreodelusuario@gmail.com".

                    // <----------------------------------------------------------------------------------------------------> //

                    // MessageBox que se mostrará si el usuario llena los campos correctamente.
                    MessageBox.Show("Su solicitud a sido enviada con éxito :)" +
                        "\nFavor de revisar su correo " + "(" + txtEmail.Text + ") para más información.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Llamada al form de Inicio de sesión.
                    Login LoginForm = new Login(); // Creación de un objeto de la clase "Login".
                    LoginForm.Show(); // ".Show()" permitirá mostrar el formulario de inicio de sesión.
                    this.Hide(); // ".Hide() ocultará el formulario actual (RegistrerUsers).
                }
            }

            /*
               Este "catch" sólo se ejecutará si el usuario deja algún textbox vacío.
            */
            catch(Exception ex){
                // MessageBox a mostrar.
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
