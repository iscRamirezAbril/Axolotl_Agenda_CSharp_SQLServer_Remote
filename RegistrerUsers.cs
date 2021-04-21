using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; // Librería que permite utilizar librerías nativas del sistema operativo
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Librerías para el envío de correos electrónicos.
using System.Net;
using System.Net.Mail;

namespace ProyectoFinal
{
    public partial class RegistrerUsers : Form{
        public RegistrerUsers(){
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // <--------------------------------------> //
        // <---------- EVENTOS / EVENTS ----------> //
        // <--------------------------------------> //

        // <--- Evento #1: "Enter" ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtSignName_Enter(object sender, EventArgs e){
            if (txtSignName.Text == "NAME"){
                txtSignName.Text = ""; // Texto a mostrar.
                txtSignName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #2: "Leave" ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtSignName_Leave(object sender, EventArgs e){
            if (txtSignName.Text == ""){
                txtSignName.Text = "NAME"; // Texto a mostrar.
                txtSignName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #3: "Enter" ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtSignLastName_Enter(object sender, EventArgs e){
            if (txtSignLastName.Text == "LAST NAME"){
                txtSignLastName.Text = ""; // Texto a mostrar.
                txtSignLastName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #4: "Leave" ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtSignLastName_Leave(object sender, EventArgs e){
            if (txtSignLastName.Text == ""){
                txtSignLastName.Text = "LAST NAME"; // Texto a mostrar.
                txtSignLastName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #5: "Enter" ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtSignUsername_Enter(object sender, EventArgs e){
            if (txtSignUsername.Text == "USERNAME"){
                txtSignUsername.Text = ""; // Texto a mostrar.
                txtSignUsername.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #6: "Leave" ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtSignUsername_Leave(object sender, EventArgs e){
            if (txtSignUsername.Text == ""){
                txtSignUsername.Text = "USERNAME"; // Texto a mostrar.
                txtSignUsername.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #7: "Enter" ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtSignEmail_Enter(object sender, EventArgs e){
            if (txtSignEmail.Text == "EMAIL ADDRESS"){
                txtSignEmail.Text = ""; // Texto a mostrar.
                txtSignEmail.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #8: "Leave" ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtSignEmail_Leave(object sender, EventArgs e){
            if (txtSignEmail.Text == ""){
                txtSignEmail.Text = "EMAIL ADDRESS"; // Texto a mostrar.
                txtSignEmail.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #9: "Enter" ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtSignPassword_Enter(object sender, EventArgs e){
            if (txtSignPassword.Text == "PASSWORD"){
                txtSignPassword.Text = ""; // Texto a mostrar.
                txtSignPassword.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
                txtSignPassword.UseSystemPasswordChar = true; // Esta condición permite que la contraseña no se visualice.
            }
        }

        // <--- Evento #10: "Leave" ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtSignPassword_Leave(object sender, EventArgs e){
            if (txtSignPassword.Text == ""){
                txtSignPassword.Text = "PASSWORD"; // Texto a mostrar.
                txtSignPassword.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
                txtSignPassword.UseSystemPasswordChar = false; // Esta condición permite que la contraseña no se visualice.
            }
        }

        // <--- Evento #11: "Enter" ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtConfirmPass_Enter(object sender, EventArgs e){
            if (txtConfirmPass.Text == "CONFIRM PASSWORD"){
                txtConfirmPass.Text = ""; // Texto a mostrar.
                txtConfirmPass.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
                txtConfirmPass.UseSystemPasswordChar = true; // Esta condición permite que la contraseña no se visualice.
            }
        }

        // <--- Evento #12: "Leave" ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtConfirmPass_Leave(object sender, EventArgs e){
            if (txtConfirmPass.Text == ""){
                txtConfirmPass.Text = "CONFIRM PASSWORD"; // Texto a mostrar.
                txtConfirmPass.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
                txtConfirmPass.UseSystemPasswordChar = false; // Esta condición permite que la contraseña no se visualice.
            }
        }

        // <--- Evento #13: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtSignUsername" no puedan
           escribirse caracteres especiales o espacios en blanco.
        */
        private void txtSignUsername_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtSignUsername", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtSignUsername.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no cumplen con los siguientes rangos de valores [64, 48 - 57, mayor a 165] en "Código ASCII".
                */
                if (Letter < 46 || Letter > 46 && Letter < 48 || Letter > 57 && Letter < 64 || Letter > 64 && Letter > 165) txtSignUsername.Text = ""; // Se vacía el textbox.
        }

        // <--- Evento #14: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtEmail" no puedan
           escribirse caracteres especiales diferentes a "@" y espacios en blanco.
        */
        private void txtSignEmail_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtSignEmail", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtSignEmail.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no se encuentra en el rango de valores entre el [48 - 57, 64, 65 - 90, 97 - 122] 
                   en "Código ASCII".
                */
                if (Letter < 46 || Letter > 46 && Letter < 48 || Letter > 57 && Letter < 64 || Letter > 64 && Letter < 65 || Letter > 95 && Letter < 97 || Letter > 122)
                    txtSignEmail.Text = ""; // Se vacía el textbox.
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "btnRegister" ---> //
        private void btnRegister_Click(object sender, EventArgs e){
            Users user = new Users{ // Creación de un objeto de la clase "User".
                /* 
                   Asiganción de los datos de los "textbox" del formulario de registro a las propiedades 
                   del objeto "user".
                */
                UsrName = txtSignName.Text,
                UsrLname = txtSignLastName.Text,
                UsrUsername = txtSignUsername.Text,
                UsrEmail = txtSignEmail.Text,
                UsrPass = txtSignPassword.Text,
                UsrConPass = txtConfirmPass.Text
            };

            try{
                Control control = new Control(); // Creación de un objeto de la clase "Control".
                string answer = control.ctrlRegister(user); // Llamada al método "ctrlRegister", enviandole como parámetro el objeto "user".

                if (answer.Length > 0){
                    // "MessageBox" que se mostrará al usuario para avisar de algun error.
                    MessageBox.Show(answer, "Notice.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else{
                    // "MessageBox" que se mostrará al usuario para confirmar su registro.
                    if(MessageBox.Show("Registered user! \nYou can now log in and start using our application!", "Registered data.", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK){
                        WelcomeEmail(); // Llamada al método que envía el correo de bienvenida.
                        
                        Login LoginForm = new Login(); // Creación de un objeto de la clase "Login".
                        LoginForm.Show(); // ".Show()" permitirá mostrar el formulario de inicio de sesión.
                        this.Hide(); // ".Hide() ocultará el formulario actual (RegistrerUsers).
                    }           
                }
            } 
            /*
               Excepción que sólo se presentará si se presenta algún tipo de error al momento de realizar
               el registro.
            */
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // <--- Botón "btnClear". ---> //
        private void btnClear_Click(object sender, EventArgs e){
            // Al momento de presionar el botón, todos los textbox del formulario volverán a su estado inicial.
            txtSignName.Text = "NAME";
            txtSignLastName.Text = "LAST NAME";
            txtSignUsername.Text = "USERNAME";
            txtSignEmail.Text = "EMAIL ADDRESS";
            txtSignPassword.Text = "PASSWORD";
            txtSignPassword.UseSystemPasswordChar = false; // Esta condición permite que la contraseña se visualice.
            txtConfirmPass.Text = "CONFIRM PASSWORD";
            txtConfirmPass.UseSystemPasswordChar = false; // Esta condición permite que la contraseña se visualice.

            txtSignName.Focus(); // El cursos volverá a la primera caja de texto (En este caso, txtSignName).
        }

        // <--- Botón "btnClose". ---> //
        private void btnClose_Click(object sender, EventArgs e){
            /* 
               Condición que sólo funcionará sí y sólo sí el usuario presiona el botón de
               "YES" del MessageBox.
            */
            if(MessageBox.Show("Are you sure you want to return to the main screen? \nAll your data will not be recorded and lost!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                Login LoginForm = new Login(); // Creación de un objeto de la clase "Login".
                LoginForm.Show(); // ".Show()" permitirá mostrar el formulario de inicio de sesión.
                this.Hide(); // ".Hide() ocultará el formulario actual (RegistrerUsers).
            }
        }

        // <--- Botón "btnMinimize". ---> //
        private void btnMinimize_Click(object sender, EventArgs e){
            this.WindowState = FormWindowState.Minimized; // Permite minimizar la ventana.
        }

        // <---------------------------------------> //
        // <---------- MÉTODOS / METHODS ----------> //
        // <---------------------------------------> //

        // <--- Método #1: Envío de email de bienvenida a la aplicación. ---> //
        private void WelcomeEmail(){
            // Se crea un objeto de la clase "MailMessage".
            MailMessage mail = new MailMessage();
            // Se crea un objeto de la clase "Smtp". Dentro de los paréntesis se escribe el "smtp" correspondiente a la compañía de correo.
            SmtpClient SmtpServerCopy = new SmtpClient("smtp.gmail.com");

            mail.To.Add(txtSignEmail.Text); // Correo que va a recibir la copia del "Feedback".
            mail.From = new MailAddress("axolotlagenda.helpusers@gmail.com", "Axolotl Agenda");
            mail.Subject = "WELCOME TO AXOLOTL AGENDA! :D"; // "Asunto" del correo.
            // Cuerpo del correo.
            mail.Body = "Welcome " + txtSignName.Text + " " + txtSignLastName.Text + "!" +
                "\nThank you for registering. We hope you enjoy this application." +
                "\n\nThe purpose of this application is for you to keep a clean and " +
                "orderly control of your daily activities, offering a clean and discreet interface." +
                "\n\nEnjoy it and make the most of it! =)";

            SmtpServerCopy.Port = 587; // Puerto.
            SmtpServerCopy.EnableSsl = true; // Habilitar "uso de aplicaciones poco seguras" para el correo del usuario.
                                             // Asignación de credenciales del correo de soporte. Se pide el correo y contraseña del mismo.
            SmtpServerCopy.Credentials = new NetworkCredential("Axolotlteam.helpusers@gmail.com", "kueuhrvtvfjefufs");
            SmtpServerCopy.Send(mail); // ".Send() es el método que permitirá mandar el mensaje.
        }
    }
}
