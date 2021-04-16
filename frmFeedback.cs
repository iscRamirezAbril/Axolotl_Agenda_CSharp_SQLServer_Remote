using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // Librería #1 para el envío de correos electrónicos.
using System.Net.Mail; // Librería #2 para el envío de correos electrónicos.

namespace ProyectoFinal
{
    public partial class frmFeedback : Form{
        public frmFeedback(){
            InitializeComponent();
        }
        // <--------------------------------------> //
        // <---------- EVENTOS / EVENTS ----------> //
        // <--------------------------------------> //

        // <--- Evento #1: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtName" no puedan
           escribirse caracteres especiales o números.
        */
        private void txtName_TextChanged(object sender, EventArgs e){
            foreach (char Letter in Encoding.ASCII.GetBytes(txtName.Text))
                if (Letter < 65 || Letter > 90 && Letter < 97 || Letter > 122){
                    // Mensaje de error que se desplegará al momento de detectar el error.
                    MessageBox.Show("Solo puede ingresar letras...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = ""; // Se vacía el textbox.
                }
        }

        // <--- Evento #2: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtLastName" no puedan
           escribirse caracteres especiales o números.
        */
        private void txtLastName_TextChanged(object sender, EventArgs e){
            foreach (char Letter in Encoding.ASCII.GetBytes(txtLastName.Text))
                if (Letter < 65 || Letter > 90 && Letter < 97 || Letter > 122){
                    // Mensaje de error que se desplegará al momento de detectar el error.
                    MessageBox.Show("Solo puede ingresar letras...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastName.Text = ""; // Se vacía el textbox.
                }
        }

        // <--- Evento #3: "TextChanged". ---> //
        /*
           Se creó este evento para el textbox de nombre "txtEmailPass", que sirve para
           que la contraseña del correo del usuario no se visualice cuando la escriba.
        */
        private void txtEmailPass_TextChanged(object sender, EventArgs e){
            txtEmailPass.UseSystemPasswordChar = true; // Esta condición permite que la contraseña no se visualice.
        }

        // <---------------------------------------> //
        // <---------- MÉTODOS / METHODS ----------> //
        // <---------------------------------------> //

        // <--- Método #1: "SelectedOptions". ---> //
        /*
           Este método se programó para imrpimir un mensaje dependiendo del "radiobutton" que
           el usuario haya seleccionado.
        */
        public string SelectedOptions(){
            // Declaración de una variable donde se almacenará la respuesta correspondiente al "radiobutton" seleccionado.
            string answer = "";
            // Condiciones que regresarán el mensaje que corresponde a cada radiobutton.
            if (radiobtnExcellent.Checked) answer = "Excelente.";
            else if (radiobtnGood.Checked) answer = "Buena.";
            else if (radiobtnAverage.Checked) answer = "Media.";
            else if (radiobtnPoor.Checked) answer = "Mala.";
            else if (radiobtnWorst.Checked) answer = "Muy mala.";

            return answer; // Retorno de valor.
        }

        // <--- Método #2: "Comment". ---> //
        /*
           Este método se declaró para verificar si el usuario insertó un comentario para
           el feedback o no.
        */
        string Comment(){
            /*
               Declaración de una variable que almacenará un mensaje dependiendo de lo que haya
               decidido el usuario.
            */
            string comment = "";

            // Condición que sólo se activará si y sólo sí el usuario no insertó un comentario.
            if (string.IsNullOrEmpty(txtComments.Text)) comment = "No existe.";
            else comment = txtComments.Text;

            return comment; // Retorno de valor.
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "btnSendFeedback". ---> //
        private void btnSendFeedback_Click(object sender, EventArgs e){

            // Condición que sólo se activará sí y sólo sí alguno de los campos "obligatorios" están vacíos.
            if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLastName.Text)
                || string.IsNullOrEmpty(txtEmail.Text)){
                // MessageBox que se mostrará cuando el usuario no llene los campos que son obligatorios.
                MessageBox.Show("Los campos 'My name', 'Last name' e 'Email' son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                // INICIO DE INSTRUCCIONES PARA EL FEEDBACK QUE RECIBIRÁ "axolotlteam.helusers@gmail.com".
                // Se crea un objeto de la clase "MailMessage".
                MailMessage msg = new MailMessage();
                // Se crea un objeto de la clase "Smtp". Dentro de los paréntesis se escribe el "smtp" correspondiente a la compañía de correo.
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                
                // Bloque de instrucciones para datos y cuerpo del correo electrónico.
                // INICIO //
                msg.To.Add("axolotlteam.helpusers@gmail.com"); // Correo que va a recibir el "Feedback".
                // Correo quien envía el Feedback.
                msg.From = new MailAddress(txtEmail.Text, Session.name + "'s" + " Feedback", Encoding.UTF8);
                msg.Subject = "FEEDBACK AXOLOTL AGENDA."; // "Asunto" del correo.
                // Cuerpo del correo.
                msg.Body = "Los datos del Feedback son los siguientes:" +
                    "\n- Nombre del usuario: " + txtName.Text +
                    "\n- Apellido del usuario: " + txtLastName.Text +
                    "\n- Calificación de la App: " + SelectedOptions() +
                    "\n- Mensaje opcional del usuario: " + Comment();

                // Este bloque de código servirá para dar credenciales al correo electrónico del usuario.
                // INICIO //
                SmtpServer.Port = 587; // Puerto.
                // Asignación de credenciales para el correo del usuario. Se pide el correo y contraseña del mismo.
                SmtpServer.Credentials = new NetworkCredential(txtEmail.Text, txtEmailPass.Text);
                SmtpServer.EnableSsl = true; // Habilitar "uso de aplicaciones poco seguras" para el correo del usuario.
                SmtpServer.Send(msg); // ".Send() es el método que permitirá mandar el mensaje.
                // FIN //
                // FIN DEL BLOQUE DE CÓDIGO DE INSTRUCCIONES DEL FEEDBACK QUE RECIBIRÁ "axolotlteam.helpusers@gmail.com".

                // <----------------------------------------------------------------------------------------------------> //

                // INICIO DE INSTRUCCIONES PARA EL FEEDBACK QUE RECIBIRÁ "el correo del usuario@gmail.com".
                // Se crea un objeto de la clase "MailMessage".
                MailMessage mail = new MailMessage();
                // Se crea un objeto de la clase "Smtp". Dentro de los paréntesis se escribe el "smtp" correspondiente a la compañía de correo.
                SmtpClient SmtpServerCopy = new SmtpClient("smtp.gmail.com");

                mail.To.Add(txtEmail.Text); // Correo que va a recibir la copia del "Feedback".
                mail.From = new MailAddress("axolotlagenda.helpusers@gmail.com", "Axolotl Agenda");
                mail.Subject = "COPY OF FEEDBACK AXOLOTL AGENDA."; // "Asunto" del correo.
                // Cuerpo del correo.
                mail.Body = "¡Gracias por su opinión!" + "\nLos datos del Feedback que usted registró son los siguientes:" +
                    "\n- Nombre del usuario: " + txtName.Text +
                    "\n- Apellido del usuario: " + txtLastName.Text +
                    "\n- Calificación de la App: " + SelectedOptions() +
                    "\n- Mensaje opcional del usuario: " + Comment();
                // FIN //

                // Este bloque de código servirá para dar credenciales al correo electrónico del usuario.
                // INICIO //
                SmtpServerCopy.Port = 587; // Puerto.
                // Asignación de credenciales del correo de soporte. Se pide el correo y contraseña del mismo.
                SmtpServerCopy.Credentials = new NetworkCredential("Axolotlteam.helpusers@gmail.com", "AxolotlTeam!35");
                SmtpServerCopy.EnableSsl = true; // Habilitar "uso de aplicaciones poco seguras" para el correo del usuario.
                SmtpServerCopy.Send(mail); // ".Send() es el método que permitirá mandar el mensaje.
                // FIN //
                // FIN DEL BLOQUE DE CÓDIGO DE INSTRUCCIONES DEL FEEDBACK QUE RECIBIRÁ "coreodelusuario@gmail.com".

                // <----------------------------------------------------------------------------------------------------> //

                // MessageBox que se mostrará cuando el usuario llene los campos correctamente.
                MessageBox.Show("¡Gracias por su opinión! :D \nLa información se envió con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Se reinician los textbox.
                txtName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtComments.Clear();
                txtEmailPass.Clear();
                // Se reinician los radiobuttons.
                radiobtnExcellent.Checked = false;
                radiobtnGood.Checked = false;
                radiobtnAverage.Checked = false;
                radiobtnPoor.Checked = false;
                radiobtnWorst.Checked = false;
            }
        }
    }
}
