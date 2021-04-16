using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient; // Librería que nos permitirá conectarnos a las bases de datos de "MySQL".
using System.Data.SqlClient;
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
            loadUserData();  // Llamada al método que permite visualizar los datos del usuario.
            panelEditUserData.Visible = true; // El panel donde se encuentra la información de usuario editable se mostrará.
        }


        // <--- Evento #2: "TextChanged". ---> //
        private void txtCurrentPass_TextChanged(object sender, EventArgs e){
            txtCurrentPass.UseSystemPasswordChar = true; // Esta condición permite que la contraseña no se visualice.
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "btnSaveEdit". ---> //
        private void btnSaveEdit_Click(object sender, EventArgs e){
            Control objCtrl = new Control(); // Creación de una instancia de la clase "Control".

            /*
              Condición que se activará sí y sólo sí alguno de los textbox de la configuración
              están vacíos.
            */
            if (txtEditName.Text == "" || txtEditLastName.Text == "" || txtEditEmail.Text == "" || txtCurrentPass.Text == ""
                || txtEditUsername.Text == "")
                MessageBox.Show("Los campos no deben estar vacíos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            /*
              Condición que te permitirá editar tus datos sí y sólo sí la contraseña insertada
              en el textbox es igual a la registrada en la base de datos.
            */
            else if (Session.password == objCtrl.Encrypt(txtCurrentPass.Text)){
                // Declaración de variables, a las cuales se les asigna el dato correspondiente al textbox.
                int usrId = Session.id;
                string usrName = txtEditName.Text;
                string usrLname = txtEditLastName.Text;
                string usrUsername = txtEditUsername.Text;
                string usrEmail = txtEditEmail.Text;

                // Declaración de variable.
                /*
                   Esta variable selecciona de la tabla "registro_usuarios" los siguientes datos de los campos correspondientes:
                   1. usrName.    3. usrUsername.  5. usrId.
                   2. usrLname.   4. usrEmail.
                   Seleccina esos campos para tener acceso a ellos y poder actualizarlos.
                */
                string sql = "UPDATE Users SET usrName='" + usrName + "', usrLname='" + usrLname + "', usrUsername='" + usrUsername + "', usrEmail='" + usrEmail + "' WHERE usrId='" + usrId + "'";
                
                // Referencia a la clase de nombre "SQLConnection".
                SqlConnection connection = SQLConnection.getConnection();
                connection.Open();  // Esta función permite abrir la conexión.

                try{
                    // Se crea un objeto de la clase "MySqlCommand", enviandole como parámetros "sql" y "conexion".
                    SqlCommand command = new SqlCommand(sql, connection);

                    // MessageBox que se muestra antes cuando los datos del usuario se modifican con éxito.
                    MessageBox.Show("¡Registro modificado con éxito! :D" +
                        "\nPara que sus datos se actualicen correctamente deberá iniciar sesión de nuevo." +
                        "\n\nFavor de cerrar sesión.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*
                       A la clase "Session" con su respectiva variable se le asigna el dato del textbox
                       correspondiente.
                   */
                    Session.name = txtEditName.Text;
                    Session.last_name = txtEditLastName.Text;
                    Session.username = txtEditUsername.Text;
                    Session.email = txtEditEmail.Text;

                    /*
                       A los labels correspondientes se les asigna el objeto de la clase "Session".
                    */
                    lblSettName.Text = Session.name;
                    lblSettLastN.Text = Session.last_name;
                    lblSettUsername.Text = Session.username;
                    lblSettEmail.Text = Session.email;
                }

                // Catch correspondiente por si se presenta algún error al momento de actualizar los datos.
                catch (MySqlException ex){
                    MessageBox.Show("Error al modifcar: " + ex.Message); // Mensaje de error.
                }
            }
            else{
                // MessageBox que se mostrará sí y sólo sí la contraseña del usuario es incorrecta.
                MessageBox.Show("Contraseña incorrecta.\nFavor de intentarlo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // <--- Botón "CancelEdit". ---> //
        private void btnCancelEdit_Click(object sender, EventArgs e){
            panelEditUserData.Visible = false; // El panel donde se encuentra la información de usuario editable no se mostrará.
            Reset(); // Se llama al método "Reset()", que deja todos los textbox en su estado original.
        }
    }
}
