using System;
using System.Drawing;
using System.Runtime.InteropServices; // Librería que permite utilizar librerías nativas del sistema operativo.
using System.Text;
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

        // <--- Evento #5: "Enter". ---> //
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

        // <--- Evento #6: "Leave". ---> //
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

        // <--- Evento #3: "MouseDown". ---> //
        /*
          Este evento nos permitirá mover el formulario desde el panel.
        */
        private void panelLogo_MouseDown(object sender, MouseEventArgs e){
            // Llamada a los métodos.
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // <--- Evento #4: "MouseDown". ---> //
        /*
          Este evento nos permitirá mover el formulario desde el panel.
        */
        private void ForgotPassword_MouseDown(object sender, MouseEventArgs e){
            // Llamada a los métodos.
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // <--- Evento #5: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtEmail" no puedan
           escribirse caracteres especiales o números.
        */
        private void txtEmail_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtSignEmail", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtEmail.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no se encuentra en el rango de valores entre el [48 - 57, 64, 65 - 90, 97 - 122] 
                   en "Código ASCII".
                */
                if (Letter < 46 || Letter > 46 && Letter < 48 || Letter > 57 && Letter < 64 || Letter > 64 && Letter < 65 || Letter > 95 && Letter < 97 || Letter > 122){
                    txtEmail.ForeColor = Color.FromArgb(220, 12, 12); // Cambio de color a "Rojo".
                    label1.ForeColor = Color.FromArgb(220, 12, 12); // Cambio de color a "Rojo".
                    // txtSignEmail.Text = ""; // Se vacía el textbox.
                }
                else{
                    txtEmail.ForeColor = Color.FromArgb(64, 64, 64); // Cambio de color a "Gris".
                    label1.ForeColor = Color.FromArgb(86, 101, 115); // Cambio de color a "Gris".
                }
        }

        // <--- Evento #6: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtUsername" no puedan
           escribirse caracteres especiales o espacios en blanco.
        */
        private void txtUsername_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtSignUsername", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtUsername.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no cumplen con los siguientes rangos de valores [64, 48 - 57, mayor a 165] en "Código ASCII".
                */
                if (Letter < 46 || Letter > 46 && Letter < 48 || Letter > 57 && Letter < 64 || Letter > 64 && Letter > 165){
                    txtUsername.ForeColor = Color.FromArgb(220, 12, 12); // Cambio de color a "Rojo".
                    label3.ForeColor = Color.FromArgb(220, 12, 12); // Cambio de color a "Rojo".
                    // txtSignUsername.Text = ""; // Se vacía el textbox.
                }
                else{
                    txtUsername.ForeColor = Color.FromArgb(64, 64, 64); // Cambio de color a "Gris".
                    label3.ForeColor = Color.FromArgb(86, 101, 115); // Cambio de color a "Gris"
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
            if (MessageBox.Show("Are you sure you want to go back to the main screen? \nIf you did not send in a request to retrieve your password, you will have to request it again!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
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
               Los datos ingresados por el usuario en los textbox se asignarán a as variables correspondientes.
            */
            string email = txtEmail.Text;
            string username = txtUsername.Text;

            try{
                Control ctrl = new Control(); // Creación de un objeto de la clase "Control".

                /*
                   Declaración de una variable de tipo "string" que almacenará la respuesta generada por el método
                   "ctrRecoverPassword()".
                */
                string errorMessage = ctrl.ctrlRecoverPassword(username, email);
                // MessageBox que se mostrará si se prresenta algún error.
                if (errorMessage.Length > 0) MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else {
                    paswordRecoveryMail(); // Llamada al método que envía un correo para recuperación de contraseña.

                    // MessageBox que se mostrará si el usuario llena los campos correctamente.
                    MessageBox.Show("Your request has been sent successfully :)" +
                        "\nPlease check your email " + "(" + txtEmail.Text + ") for more information.", "Notice",
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
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // <---------------------------------------> //
        // <---------- MÉTODOS / METHODS ----------> //
        // <---------------------------------------> //

        // <--- Método #1: Método para enviar un correo de recuperación de contraseña. ---> //
        private void paswordRecoveryMail(){
            // INICIO DE INSTRUCCIONES PARA EL FEEDBACK QUE RECIBIRÁ "el correo del usuario@gmail.com".
            // Se crea un objeto de la clase "MailMessage".
            MailMessage mail = new MailMessage();
            // Se crea un objeto de la clase "SmtpClient". Dentro de los paréntesis se escribe el "smtp" correspondiente a la compañía de correo.
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.To.Add(txtEmail.Text); // Correo que va a recibir la contraseña.
            mail.From = new MailAddress("axolotlagenda.helpusers@gmail.com", "Axolotl Agenda");
            mail.Subject = "PASSWORD RECOVERY."; // "Asunto" del correo.

            // Cuerpo del correo.
            mail.Body = "You have requested to recover your password." +
                "\nThe password for your login is: " + Session.password +
                "\nWe recommend that you keep your password in a safe and easy to remember place." +
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
        }
    }
}
