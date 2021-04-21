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
    public partial class frmUsersControl : Form{

        // Constructor.
        public frmUsersControl(){
            InitializeComponent();
            ReloadUsersTable(null); // Llamada al método que permitirá actaulizar la tabla de usuarios.
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "iconbtnSearch". ---> //
        /*
           Este botón permitirá buscar un usuario en la tabla de usuarios registrados.
        */
        private void iconbtnSearch_Click(object sender, EventArgs e){
            string dato = txtSearch.Text;
            ReloadUsersTable(dato);
        }

        // <--- Botón "iconSave". ---> //
        /*
           Este botón permitirá guardar y registrar un nuevo usuario.
        */
        private void iconbtnSave_Click(object sender, EventArgs e){
            Users user = new Users(); // Creación de un objeto de la clase "Users".

            /* 
               Asiganción de los datos de los "textbox" del formulario de registro a las propiedades 
               del objeto "user".
            */
            user.UsrName = txtName.Text;
            user.UsrLname = txtLastName.Text;
            user.UsrUsername = txtUsername.Text;
            user.UsrEmail = txtEmail.Text;
            user.UsrPass = txtPass.Text;

            try{
                Control ctrl = new Control(); // Creación de un objeto de la clase "Control".

                /*
                   Declaración de una variable de tipo "string" que almacenará la respuesta generada por el método
                   "ctrlregistrer()".
                */
                string errorMessage = ctrl.ctrlregisterAdmins(user); // Llamada al método "ctrlregisterAdmins", enviandole como parámetro el objeto "user".

                /*
                   Condición que sólo es válida sí y sólo sí la respuesta tiene algún mensaje. Significa que,
                   el administrador cometió algún error al registrar los datos de un nuevo usuario.
                */
                                             // "MessageBox" que se mostrará al usuario para avisar de algun error.
                if (errorMessage.Length > 0) MessageBox.Show(errorMessage, "Notice.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else{
                    // "MessageBox" que se mostrará al usuario para confirmar su registro.
                    MessageBox.Show("Successfully registered user!", "Recorded data.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean(); // Llamada al método para limpiar los textbox.
                    ReloadUsersTable(null); // Llamada al método que permite actualizar la tabla.
                }
            }

            /*
               Este "catch" sólo se ejecutará si el usuario deja algún textbox vacío.
            */
            catch (Exception ex){
                // MessageBox a mostrar.
                MessageBox.Show(ex.Message, "Notice.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // <--- Botón "btnModify". ---> //
        /*
           Botón que permitirá modificar los datos de un usuario.
        */
        private void btnModify_Click(object sender, EventArgs e){
            Control objCtrl = new Control(); // Creación de una instancia de la clase "Control".

            /* 
               Asiganción de los datos de los "textbox" del formulario de registro a las propiedades 
               del objeto "user".
            */
            string UsrName = txtName.Text;
            string UsrLname = txtLastName.Text;
            string UsrUsername = txtUsername.Text;
            string UsrEmail = txtEmail.Text;
            string UsrPass = objCtrl.Encrypt(txtPass.Text);
            int UsridRol = Convert.ToInt32(txtIdRol.Text);
            int UsrId = Convert.ToInt32(txtId.Text);

            Control ctrl = new Control(); // Creación de un objeto de la clase "Control".
            string respuesta = ctrl.ctrlModifyAdmin(UsrName, UsrLname, UsrUsername, UsrEmail, UsrPass, UsridRol, UsrId); // Llamada al método "ctrlregisterAdmins", enviandole como parámetro el objeto "user".
                                        // "MessageBox" que se mostrará al usuario para avisar de algun error.
            if (respuesta.Length > 0) MessageBox.Show(respuesta, "Notice.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else{
                // MessageBox que se muestra cuando los datos del usuario se modifican con éxito.
                MessageBox.Show("User data successfully modified!", "Updated user data.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean(); // Llamada al método para limpiar los textbox.
                ReloadUsersTable(null); // Llamada al método que permite actualizar la tabla.
            }
        }

        // <--- Botón "iconbtnDelete". ---> //
        /*
           Botón que permitirá eliminar un usuario.
        */
        private void iconbtnDelete_Click(object sender, EventArgs e){
            // Declaración de una variable que almacenará el id del usuario.
            int usrId = Convert.ToInt32(txtId.Text);

            // Condición que sólo se ejecutará si el administrador dá click al botón "Yes" del MessageBox.
            if (MessageBox.Show("Are you sure you want to remove this user from the Database?" +
                "\nYou will not be able to recover the data!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){

                Model model = new Model(); // Creación de un objeto de la clase "Model".
                model.DeleteAccount(usrId);

                // MessageBox que se muestra cuando los datos del usuario se eliminan con éxito.
                MessageBox.Show("User removed from the Database!", "User removed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean(); // Llamada al método para limpiar los textbox.
                ReloadUsersTable(null); // Llamada al método que permite actualizar la tabla.
            }
        }

        // <--- Botón "iconbtnClean". ---> //
        /*
           Botón que reinicia los textboxes a su estado original.
        */
        private void iconbtnClean_Click(object sender, EventArgs e){
            Clean(); // Llamada al método que reinicia los textboxes.
        }

        // <---------------------------------------> //
        // <---------- MÉTODOS / METHODS ----------> //
        // <---------------------------------------> //

        // <--- Método #1: Cargar datos a "DataGridView". ---> //
        private void ReloadUsersTable(string dato){
            List < Users > Lista = new List<Users>();
            Model ctrlUsuarios = new Model();
            dataGridUsers.DataSource = ctrlUsuarios.userQuery(dato);
        }

        // <--- Método #2: Método que permitirá limpiar las "textboxes" del formulario. ---> //
        private void Clean(){
            txtId.Text = "ID";
            txtName.Text = "NAME";
            txtLastName.Text = "LAST NAME";
            txtUsername.Text = "USERNAME";
            txtEmail.Text = "EMAIL";
            txtPass.Text = "PASSWORD";
            txtIdRol.Text = "ID_ROL";
        }

        // <--------------------------------------> //
        // <---------- EVENTOS / EVENTS ----------> //
        // <--------------------------------------> //

        // <--- Evento #1: "Enter". ---> //
        /*
            Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
            caja de texto.
        */
            private void txtSearch_Enter(object sender, EventArgs e){
                if (txtSearch.Text == "SEARCH"){
                    txtSearch.Text = ""; // Texto a mostrar.
                    txtSearch.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
                }
            }

        // <--- Evento #2: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtSearch_Leave(object sender, EventArgs e){
            if (txtSearch.Text == ""){
                txtSearch.Text = "SEARCH"; // Texto a mostrar.
                txtSearch.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #3: "Enter". ---> //
        /*
            Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
            caja de texto.
        */
        private void txtId_Enter(object sender, EventArgs e){
            if (txtId.Text == "ID"){
                txtId.Text = ""; // Texto a mostrar.
                txtId.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #4: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtId_Leave(object sender, EventArgs e){
            if (txtId.Text == ""){
                txtId.Text = "ID"; // Texto a mostrar.
                txtId.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #5: "Enter". ---> //
        /*
            Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
            caja de texto.
        */
        private void txtName_Enter(object sender, EventArgs e){
            if (txtName.Text == "NAME"){
                txtName.Text = ""; // Texto a mostrar.
                txtName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #6: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtName_Leave(object sender, EventArgs e){
            if (txtName.Text == ""){
                txtName.Text = "NAME"; // Texto a mostrar.
                txtName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #7: "Enter". ---> //
        /*
            Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
            caja de texto.
        */
        private void txtLastName_Enter(object sender, EventArgs e){
            if (txtLastName.Text == "LAST NAME"){
                txtLastName.Text = ""; // Texto a mostrar.
                txtLastName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #8: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtLastName_Leave(object sender, EventArgs e){
            if (txtLastName.Text == ""){
                txtLastName.Text = "LAST NAME"; // Texto a mostrar.
                txtLastName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #9: "Enter". ---> //
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

        // <--- Evento #10: "Leave". ---> //
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

        // <--- Evento #11: "Enter". ---> //
        /*
            Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
            caja de texto.
        */
        private void txtEmail_Enter(object sender, EventArgs e){
            if (txtEmail.Text == "EMAIL"){
                txtEmail.Text = ""; // Texto a mostrar.
                txtEmail.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #12: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtEmail_Leave(object sender, EventArgs e){
            if (txtEmail.Text == ""){
                txtEmail.Text = "EMAIL"; // Texto a mostrar.
                txtEmail.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #13: "Enter". ---> //
        /*
            Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
            caja de texto.
        */
        private void txtIdTipo_Enter(object sender, EventArgs e){
            if (txtIdRol.Text == "ID_ROL"){
                txtIdRol.Text = ""; // Texto a mostrar.
                txtIdRol.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #14: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtIdTipo_Leave(object sender, EventArgs e){
            if (txtIdRol.Text == ""){
                txtIdRol.Text = "ID_ROL"; // Texto a mostrar.
                txtIdRol.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #15: "Enter". ---> //
        /*
            Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
            caja de texto.
        */
        private void txtPass_Enter(object sender, EventArgs e){
            if (txtPass.Text == "PASSWORD"){
                txtPass.Text = ""; // Texto a mostrar.
                txtPass.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #16: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtPass_Leave(object sender, EventArgs e){
            if (txtPass.Text == ""){
                txtPass.Text = "PASSWORD"; // Texto a mostrar.
                txtPass.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #17: "CellClick". ---> //
        /*
           Este evento servirá para programar lo que sucederá con la información de la celda seleccionada
           del "DataGridview". En este caso, al momento de seleccionar algún dato de una fila correspondiente,
           los datos de dicha fila se mostrarán en los Textboxes y ComboBoxes correspondientes.
        */
        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e){
            Control objCtrl = new Control();

            // Los valores que correspondan a cierta celda de la fila del DataGridView se asginarán a los textbox.
            txtId.Text = dataGridUsers.CurrentRow.Cells[0].Value.ToString();
            txtIdRol.Text = dataGridUsers.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dataGridUsers.CurrentRow.Cells[2].Value.ToString();
            txtLastName.Text = dataGridUsers.CurrentRow.Cells[3].Value.ToString();
            txtUsername.Text = dataGridUsers.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridUsers.CurrentRow.Cells[5].Value.ToString();
            // Debido a que la contraseña está encriptada en la base de datos, se manda la contraseña desesncriptada al textbox.
            txtPass.Text = objCtrl.Desencrypt(dataGridUsers.CurrentRow.Cells[6].Value.ToString());
        }

        // <--- Evento #18: "TextChanged". ---> //
        /*
            Este evento se programó para que en el texbox de nombre "txtUsername" no puedan
            escribirse caracteres especiales o letras.
        */
        private void txtUsername_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtUsername", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtUsername.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no cumplen con los siguientes rangos de valores [48 - 57, 64, mayor a 165] en "Código ASCII".
                */
                if (Letter < 46 || Letter > 46 && Letter < 48 || Letter > 57 && Letter < 64 || Letter > 64 && Letter > 165) txtUsername.Text = ""; // Se vacía el textbox.
        }

        // <--- Evento #19: "TextChanged". ---> //
        /*
           Este evento se programó para que en el texbox de nombre "txtEmail" no puedan
           escribirse caracteres especiales diferentes a "@" y espacios en blanco.
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

        // <--- Evento #20: "TextChanged". ---> //
        /*
            Este evento se programó para que en el texbox de nombre "txtIdRol" no puedan
            escribirse caracteres especiales o letras.
        */
        private void txtIdRol_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtIdRol", se obtendrá un byte en "Código ASCII".
            foreach (int Number in Encoding.ASCII.GetBytes(txtIdRol.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no se encuentra en el rango de valores entre el [48 - 57] en "Código ASCII".
                */
                if (Number < 48 || Number > 57) txtIdRol.Text = "";           
        }

        // <--- Evento #21: "TextChanged". ---> //
        /*
            Este evento se programó para que en el texbox de nombre "txtName" no puedan
            escribirse caracteres especiales o números.
        */
        private void txtName_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtName", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtName.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no se encuentra en el rango de valores entre el [32, 65 - 90, 97 - 122] 
                   en "Código ASCII".
                */
                if (Letter < 32 || Letter > 32 && Letter < 65 || Letter > 90 && Letter < 97 || Letter > 122)
                    txtName.Text = ""; // Se vacía el textbox.
        }

        // <--- Evento #22: "TextChanged". ---> //
        /*
            Este evento se programó para que en el texbox de nombre "txtLastName" no puedan
            escribirse caracteres especiales o números.
        */
        private void txtLastName_TextChanged(object sender, EventArgs e){
            // Por cada Valor insertado en "txtName", se obtendrá un byte en "Código ASCII".
            foreach (char Letter in Encoding.ASCII.GetBytes(txtName.Text))
                /*
                   Condición que sólo se activará sí y sólo sí el valor que se escriba en el textbox
                   no se encuentra en el rango de valores entre el [32, 65 - 90, 97 - 122] 
                   en "Código ASCII".
                */
                if (Letter < 32 || Letter > 32 && Letter < 65 || Letter > 90 && Letter < 97 || Letter > 122)
                    txtName.Text = ""; // Se vacía el textbox.
        }
    }
}
