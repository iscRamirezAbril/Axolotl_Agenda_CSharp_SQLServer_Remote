using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmSettings : Form{

        // Constructor.
        public frmSettings(){
            InitializeComponent();

            /*
               A los labels correspondientes se les asigna de la clase "Session" sus
               respectivas propiedades.
            */
            lblSettName.Text = Session.name;
            lblSettLastN.Text = Session.last_name;
            lblSettUsername.Text = Session.username;
            lblSettEmail.Text = Session.email;

            /*
               A los textbox correspondientes se les asigna de la clase "Session" sus
               respectivas propiedades.
            */
            txtEditName.Text = Session.name;
            txtEditLastName.Text = Session.last_name;
            txtEditUsername.Text = Session.username;
            txtEditEmail.Text = Session.email;
        }

        // <--- Evento #1: "Load". ---> //
        private void frmSettings_Load(object sender, EventArgs e){
            
        }

        // ----------------------------- //
        // ----- MÉTODOS / METHODS ----- //
        // ----------------------------- //

        // <--- Método #1: "Reset". ---> //
        private void Reset(){
            loadUserData(); // Llamada al método que permite visualizar los datos del usuario.
        }

        // <--- Método #2: Visualizar datos de usuario ---> //
        public void loadUserData(){
            /*
               A los labels correspondientes se les asigna de la clase "Session" sus
               respectivas propiedades.
            */
            lblSettName.Text = Session.name;
            lblSettLastN.Text = Session.last_name;
            lblSettUsername.Text = Session.username;
            lblSettEmail.Text = Session.email;

            /*
               A los textbox correspondientes se les asigna de la clase "Session" sus
               respectivas propiedades.
            */
            txtEditName.Text = Session.name;
            txtEditLastName.Text = Session.last_name;
            txtEditUsername.Text = Session.username;
            txtEditEmail.Text = Session.email;
            txtCurrentPass.Text = "";
        }

        // <--------------------------------------> //
        // <---------- EVENTOS / EVENTS ----------> //
        // <--------------------------------------> //

        // <--- Evento #1: "LinkClicked". ---> //
        /*
          Evento que se activa cuando se da "click" en el label que abrirá el panel de edición.
        */
        private void linkLabelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            panelEditUserData.Visible = true; // El panel donde se encuentra la información de usuario editable se mostrará.
            loadUserData();  // Llamada al método que permite visualizar los datos del usuario.
        }

        // <--- Evento #2: "TextChanged". ---> //
        /*
           Evento que permite a los usuarios no poder visualizar su contraseña mientras la escribe en
           el textbox.
        */
        private void txtCurrentPass_TextChanged(object sender, EventArgs e){
            txtCurrentPass.UseSystemPasswordChar = true; // Esta condición permite que la contraseña no se visualice.
        }

        // <--- Evento #3: "KeyPress". ---> //
        /*
           Este evento se programó para que en el textbox correspondiente sólo sea válido el
           escribir letras y espacios en blanco.
        */
        private void txtEditName_KeyPress(object sender, KeyPressEventArgs e){
            if (Char.IsLetter(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        // <--- Evento #4: "KeyPress". ---> //
        /*
           Este evento se programó para que en el textbox correspondiente sólo sea válido el
           escribir letras y espacios en blanco.
        */
        private void txtEditLastName_KeyPress(object sender, KeyPressEventArgs e){
            if (Char.IsLetter(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        // <--- Evento #5: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtEditEmail" no puedan
           escribirse caracteres especiales diferentes a "@" y espacios en blanco.
        */
        private void txtEditEmail_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtEmail", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtEditEmail.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no se encuentra en el rango de valores entre el [48 - 57, 64, 65 - 90, 97 - 122] 
                   en "Código ASCII".
                */
                if (Letter < 46 || Letter > 46 && Letter < 48 || Letter > 57 && Letter < 64 || Letter > 64 && Letter < 65 || Letter > 95 && Letter < 97 || Letter > 122)
                    txtEditEmail.Text = ""; // Se vacía el textbox.
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "btnSaveEdit". ---> //
        private void btnSaveEdit_Click(object sender, EventArgs e){
            // Declaración de variables, a las cuales se les asigna el dato correspondiente al textbox.
            string usrName = txtEditName.Text;
            string usrLname = txtEditLastName.Text;
            string usrUsername = txtEditUsername.Text;
            string usrEmail = txtEditEmail.Text;
            string usrPass = txtCurrentPass.Text;

            try{
                Control objCtrl = new Control(); // Creación de una instancia de la clase "Control".

                /*
                   Declaración de una variable de tipo "string" que almacenará la respuesta generada por el método
                   "ctrRecoverPassword()".
                */
                string errorMessage = objCtrl.ctrlUpdateSession(usrName, usrLname, usrUsername, usrEmail, objCtrl.Encrypt(usrPass));
                // MessageBox que se mostrará si se prresenta algún error.
                if (errorMessage.Length > 0) MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else{
                    // MessageBox a mostrar cuando los datos del usuario se actualicen correctamente.
                    MessageBox.Show("Successfully updated information!" +
                        "\nTo view them correctly, we recommend that you log out and log in again.", "Data update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // <--- Botón "CancelEdit". ---> //
        private void btnCancelEdit_Click(object sender, EventArgs e){
            panelEditUserData.Visible = false; // El panel donde se encuentra la información de usuario editable no se mostrará.
            Reset(); // Se llama al método "Reset()", que deja todos los textbox en su estado original.
        }
    }
}
