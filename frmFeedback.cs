using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Librerías para el envío de correos electrónicos.
using System.Net;
using System.Net.Mail;

namespace ProyectoFinal
{
    public partial class frmFeedback : Form{
        public frmFeedback(){
            InitializeComponent();
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "btnSendFeedback". ---> //
        private void btnSendFeedback_Click(object sender, EventArgs e){
            // Declaración de variables
            /*
               Los datos ingresados por el usuario en los textbox se asignarán a as variables correspondientes.
            */
            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string email = txtEmail.Text;

            try{
                Control ctrl = new Control(); // Creación de un objeto de la clase "Control".

                /*
                   Declaración de una variable de tipo "string" que almacenará la respuesta generada por el método
                   "ctrRecoverPassword()".
                */
                string errorMessage = ctrl.ctrlFeedback(name, lastname, email);
                // MessageBox que se mostrará si se prresenta algún error.
                if (errorMessage.Length > 0) MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else{
                    // Llamada a los metodos que se encargan de enviar los emails.
                    EmailMessageAxolotl();
                    EmailMessageUser();

                    // MessageBox que se mostrará cuando el usuario llene los campos correctamente.
                    MessageBox.Show("Thank you for your feedback! :D \nThe information was sent successfully.", "Notice.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear(); // Llamada al método que reinicia al Form.
                }
            }

            /*
               Este "catch" sólo se ejecutará si el usuario deja algún textbox vacío.
            */
            catch (Exception ex){
                // MessageBox a mostrar.
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // <--------------------------------------> //
        // <---------- EVENTOS / EVENTS ----------> //
        // <--------------------------------------> //

        // <--- Evento #1: "KeyPress". ---> //
        /*
           Este evento se programó para que en el textbox correspondiente sólo sea válido el
           escribir letras y espacios en blanco.
         */
        private void txtName_KeyPress(object sender, KeyPressEventArgs e){
            if (Char.IsLetter(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        // <--- Evento #2: "KeyPress". ---> //
        /*
           Este evento se programó para que en el textbox correspondiente sólo sea válido el
           escribir letras y espacios en blanco.
        */
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e){
            if (Char.IsLetter(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        // <--- Evento #3: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtEmail" no puedan
           escribirse caracteres especiales o números.
        */
        private void txtEmail_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtEmail", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtEmail.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no se encuentra en el rango de valores entre el [48 - 57, 64, 65 - 90, 96 - 122] 
                   en "Código ASCII".
                */
                if (Letter < 46 || Letter > 46 && Letter < 48 || Letter > 57 && Letter < 64 || Letter > 64 && Letter < 65 || Letter > 95 && Letter < 96 || Letter > 122)
                    txtEmail.Text = ""; // Se vacía el textbox.
        }

        // <---------------------------------------> //
        // <---------- MÉTODOS / METHODS ----------> //
        // <---------------------------------------> //

        // <--- Método #1: "SelectedOptions". ---> //
        /*
           Este método se programó para imrpimir un mensaje dependiendo del "radiobutton" que
           el usuario haya seleccionado.
        */
        private string SelectedOptions(){
            // Declaración de una variable donde se almacenará la respuesta correspondiente al "radiobutton" seleccionado.
            string answer = "";
            // Condiciones que regresarán el mensaje que corresponde a cada radiobutton.
            if (radiobtnExcellent.Checked) answer = "Excellent.";
            else if (radiobtnGood.Checked) answer = "Good";
            else if (radiobtnAverage.Checked) answer = "Average";
            else if (radiobtnPoor.Checked) answer = "Poor";
            else if (radiobtnWorst.Checked) answer = "Worst.";

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
            if (string.IsNullOrEmpty(txtComments.Text)) comment = "No additional comments.";
            else comment = txtComments.Text;

            return comment; // Retorno de valor.
        }

        // <--- Método #3: Reiniciar Form a su estado original. ---> //
        private void Clear(){
            // Se reinician los textbox.
            txtName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtComments.Clear();
            // Se reinician los radiobuttons.
            radiobtnExcellent.Checked = false;
            radiobtnGood.Checked = false;
            radiobtnAverage.Checked = false;
            radiobtnPoor.Checked = false;
            radiobtnWorst.Checked = false;
        }

        // <--- Método #4: Envío de Email de las respuestas del Feedback a "axolotlagendahelpusers". ---> //
        private void EmailMessageAxolotl(){
            // Se crea un objeto de la clase "MailMessage".
            MailMessage msg = new MailMessage();
            // Se crea un objeto de la clase "Smtp". Dentro de los paréntesis se escribe el "smtp" correspondiente a la compañía de correo.
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            // Bloque de instrucciones para datos y cuerpo del correo electrónico.
            msg.To.Add("axolotlteam.helpusers@gmail.com"); // Correo que va a recibir el "Feedback".
                                                           // Correo quien envía el Feedback.
            msg.From = new MailAddress(txtEmail.Text, Session.name + "'s" + " Feedback", Encoding.UTF8);
            msg.Subject = "FEEDBACK AXOLOTL AGENDA."; // "Asunto" del correo.
                                                      // Cuerpo del correo.
            msg.Body = "The feedback data are as follows:" +
                "\n- User name: " + txtName.Text +
                "\n- User Last name: " + txtLastName.Text +
                "\n- App Rating: " + SelectedOptions() +
                "\n- Comment from user: " + Comment();

            // Este bloque de código servirá para dar credenciales al correo electrónico del usuario.
            SmtpServer.Port = 587; // Puerto.
            SmtpServer.EnableSsl = true; // Habilitar "uso de aplicaciones poco seguras" para el correo del usuario.
                                         // Asignación de credenciales para el correo del usuario. Se pide el correo y contraseña del mismo.
            SmtpServer.Credentials = new NetworkCredential("Axolotlteam.helpusers@gmail.com", "kueuhrvtvfjefufs");
            SmtpServer.Send(msg); // ".Send() es el método que permitirá mandar el mensaje.
        }

        // <--- Método #5: Envío de Email de la copia de las respuestas del feedback al correo del usuario. ---> //
        private void EmailMessageUser(){
            // Se crea un objeto de la clase "MailMessage".
            MailMessage mail = new MailMessage();
            // Se crea un objeto de la clase "Smtp". Dentro de los paréntesis se escribe el "smtp" correspondiente a la compañía de correo.
            SmtpClient SmtpServerCopy = new SmtpClient("smtp.gmail.com");

            mail.To.Add(txtEmail.Text); // Correo que va a recibir la copia del "Feedback".
            mail.From = new MailAddress("axolotlagenda.helpusers@gmail.com", "Axolotl Agenda");
            mail.Subject = "COPY OF FEEDBACK AXOLOTL AGENDA."; // "Asunto" del correo.
                                                               // Cuerpo del correo.
            mail.Body = "Thank you for your feedback!" + "\nThe Feedback data you recorded is as follows:" +
                "\n- Your name: " + txtName.Text +
                "\n- Your last name: " + txtLastName.Text +
                "\n- Your App rating: " + SelectedOptions() +
                "\n- Your comments: " + Comment();

            SmtpServerCopy.Port = 587; // Puerto.
            SmtpServerCopy.EnableSsl = true; // Habilitar "uso de aplicaciones poco seguras" para el correo del usuario.
                                             // Asignación de credenciales del correo de soporte. Se pide el correo y contraseña del mismo.
            SmtpServerCopy.Credentials = new NetworkCredential("Axolotlteam.helpusers@gmail.com", "kueuhrvtvfjefufs");
            SmtpServerCopy.Send(mail); // ".Send() es el método que permitirá mandar el mensaje.
        }
    }
}
