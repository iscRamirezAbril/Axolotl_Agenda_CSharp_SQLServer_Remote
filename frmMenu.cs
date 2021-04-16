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
    public partial class frmMenu : Form{

        // Constructor.
        public frmMenu(){
            InitializeComponent();
            ReloadActTable(null); // Llamada al método que permitirá actaulizar la tabla de usuarios.
        }

        // <--------------------------------------> //
        // <---------- EVENTOS / EVENTS ----------> //
        // <--------------------------------------> //

        // <--- Evento #1: "Tick". --->
        /*
           Evento que nos permitirá ver la hora actual del sistema (servirá como
           reloj digital).
        */
        private void timerDigitalClock_Tick(object sender, EventArgs e){
            // Al label "lblClock" se le asignará el formato largo de hora del sistema.
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        // <--- Evento #2: "Load". ---> //
        private void frmMenu_Load(object sender, EventArgs e){
            // Propiedades que tendrán los ComboBox al momento de abrir el formulario.
            ComboBType.SelectedIndex = 0; // El valor inicial del ComboBox es el que se encuentra en la posición "0".
        }

        // <--- Evento #3: "Enter". ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtName_Enter(object sender, EventArgs e){
            if (txtName.Text == "ACTIVITY NAME"){
                txtName.Text = ""; // Texto a mostrar.
                txtName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #4: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtName_Leave(object sender, EventArgs e){
            if (txtName.Text == ""){
                txtName.Text = "ACTIVITY NAME"; // Texto a mostrar.
                txtName.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #5: "Enter". ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtStart_Enter(object sender, EventArgs e){
            if (txtStart.Text == "START"){
                txtStart.Text = ""; // Texto a mostrar.
                txtStart.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #6: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtStart_Leave(object sender, EventArgs e){
            if (txtStart.Text == ""){
                txtStart.Text = "START"; // Texto a mostrar.
                txtStart.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #7: "Enter". ---> //
        /*
           Este evento sólo se "activará" si el cursor del Mouse se encuentra dentro de la 
           caja de texto.
        */
        private void txtEnd_Enter(object sender, EventArgs e){
            if (txtStart.Text == "END"){
                txtStart.Text = ""; // Texto a mostrar.
                txtStart.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #6: "Leave". ---> //
        /*
           Este evento sólo se "activará" cuando el cursor del Mouse se encuentre fuera de
           la caja de texto.
        */
        private void txtEnd_Leave(object sender, EventArgs e){
            if (txtStart.Text == ""){
                txtStart.Text = "END"; // Texto a mostrar.
                txtStart.ForeColor = Color.FromArgb(64, 64, 64); // Color de texto.
            }
        }

        // <--- Evento #13: "CellClick". ---> //
        /*
           Este evento servirá para programar lo que sucederá con la información de la celda seleccionada
           del "DataGridview". En este caso, al momento de seleccionar algún dato de una fila correspondiente,
           los datos de dicha fila se mostrarán en los Textboxes y ComboBoxes correspondientes.
        */
        private void dataGridActivities_CellClick(object sender, DataGridViewCellEventArgs e){
            // Los valores que correspondan a cierta celda de la fila del DataGridView se asginarán a los textbox y ComboBoxes.
            txtName.Text = dataGridActivities.CurrentRow.Cells[2].Value.ToString();
            ComboBType.SelectedItem = dataGridActivities.CurrentRow.Cells[3].Value.ToString();
            txtStart.Text = dataGridActivities.CurrentRow.Cells[4].Value.ToString();
            txtEnd.Text = dataGridActivities.CurrentRow.Cells[5].Value.ToString();
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "btnAgregar". ---> //
        // Botón que permite agregar una actividad a la tabla.
        private void btnAgregarAct_Click(object sender, EventArgs e){
            Activities activity = new Activities(); // Creación de un objeto de la clase "actividades".

            /* 
               Asiganción de los datos de los "textbox" del formulario de registro a las propiedades 
               del objeto "usuario".
            */
            activity.ActName = txtName.Text;
            activity.ActType = ComboBType.SelectedItem.ToString();
            activity.ActStart = Convert.ToDateTime(txtStart.Text);
            activity.ActEnd = Convert.ToDateTime(txtEnd.Text);

            try{
                Control control = new Control(); // Creación de un objeto de la clase "Control".
                string errorMessage = control.ctrlActLog(activity); // Llamada al método "ctrlActLog", enviandole como parámetro el objeto "actividad".

                if (errorMessage.Length > 0){
                    // "MessageBox" que se mostrará al usuario para avisar de algun error.
                    MessageBox.Show(errorMessage, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else{
                    // "MessageBox" que se mostrará al usuario para confirmar su registro.
                    MessageBox.Show("¡Actividad registrada con éxito!", "Datos registrados.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean(); // Llamada al método para limpiar los textbox.
                    ReloadActTable(null); // Llamada al método que permite actualizar la tabla.
                }
            }
            // Catch que sólo se activará si el administrador presenta algún tipo de error al registrar un usuario.
            catch (Exception ex){
                MessageBox.Show(ex.Message); // Mensaje de error.
            }
        }

        // <--- Botón "btnDelete". ---> //
        // Botón que permite eliminar una actividad de la tabla.
        private void btnRemove_Click(object sender, EventArgs e){
            string ActName = txtName.Text;

            // Condición que sólo se ejecutará sí y sólo sí el usuario presiona el botón "Yes" del MessageBox.
            if(MessageBox.Show("¿Seguro que quiere eliminar la actividad?\nTendrá que registrarla de nuevo.", 
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){

                Model model = new Model(); // Creación de un objeto de la clase "Model".
                model.DeleteAct(ActName);

                // MessageBox que se muestra cuando los datos de la actividad se eliminan con éxito.
                MessageBox.Show("¡Actividad eliminada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean(); // Llamada al método para limpiar los textbox.
                ReloadActTable(null); // Llamada al método que permite actualizar la tabla.
            }
        }

        // <--- Botón "btnDates". ---> //
        // Botón que permite mostrar en los textboxes correspondientes las fechas de inicio y fin seleccionadas por el usuario.
        private void btnDates_Click(object sender, EventArgs e){
            /*
              Se crean dos variables de tipo "DateTime", las cuales almacenarán las fechas y 
              horas de inicio y fin de una actividad.
            */
            DateTime Start = Calendar.SelectionStart;
            DateTime End = Calendar.SelectionEnd;

            // Las variables anteriores se asignan a los textboxes correspondientes.
            txtStart.Text = Start.ToString();
            txtEnd.Text = End.ToString();
        }

        // <---------------------------------------> //
        // <---------- MÉTODOS / METHODS ----------> //
        // <---------------------------------------> //

        // <--- Método #1: Cargar datos al "DataGridView". ---> //
        private void ReloadActTable(string act){
            List < Activities > Lista = new List<Activities>();
            Model activities = new Model();
            dataGridActivities.DataSource = activities.ActQuery(act);
        }

        // <--- Método #2: Método que permitirá limpiar las "textboxes" del formulario. ---> //
        private void Clean(){
            txtName.Text = "NAME";
            ComboBType.SelectedIndex = 0;
            txtStart.Text = "START";
            txtEnd.Text = "END";
        }
    }
}
