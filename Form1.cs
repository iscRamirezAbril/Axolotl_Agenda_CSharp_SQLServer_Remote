﻿using System;
using System.Drawing;
using System.Runtime.InteropServices; // Librería que permite utilizar librerías nativas del sistema operativo.
using System.Windows.Forms;
using FontAwesome.Sharp; // Librería que no ayuda con el diseño.

namespace ProyectoFinal
{
    public partial class Form1 : Form{
        // Declaración de una variable global que permite almacenar el tipo de usuario que inicia sesión.
        int usrRol;

        // --------------------------- //
        // ----- CAMPOS / FIELDS ----- //
        // --------------------------- //

        // Estos campos ayudarán con el diseño de los botones.
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentSecondForm;

        // Constructor.
        public Form1(){
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60); // Tamaño.
            panelMenu.Controls.Add(leftBorderBtn);

            // Form
            this.Text = string.Empty;
            this.ControlBox = false; // Se elimina el "ControlBox".
            this.DoubleBuffered = true;

            // Labels
            /*
               Los labels correspondientes tendrán los datos del usuario que inicie sesión.
            */
            lblUsername.Text = "Username: " + Session.username;
            lblName.Text = "Name: " + Session.name + " " + Session.last_name;
            lblEmail.Text = "Email: " + Session.email;

            /*
              A la variable "usrRol" se le asignará el tipo de "id" correspondiente
              al usuario que inicia sesión.
            */
            usrRol = Session.id_rol;

            /*
              Condición que permitirá visualizar el botón de registro de usuarios sólo a los administradores.
              (Los administradores tienen un id "1").
           */
            if(usrRol == 1){
                this.iconbtnRegisterUsers.Visible = true; // Visualizar el botón de registro de usuarios.
            }
            else{
                this.iconbtnRegisterUsers.Visible = false; // No visualizar el botón de registro de usuarios.
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Struct.
        /*
          Almacenar colores RGB.
        */
        private struct RGBColors{
            public static Color color6 = Color.FromArgb(255, 255, 255);
            public static Color color5 = Color.FromArgb(0, 0, 0);
        }

        // ----------------------------- //
        // ----- MÉTODOS / METHODS ----- //
        // ----------------------------- //

        // <--- Método #1: "ActivateButton" ---> //
        /*
           Este método sirve para resaltar los botones del menú de distinto color al momento
           de pasar el cursor sobre ellos.
        */
        private void ActivateButton(object senderBtn, Color color){
            // Condición que verifica que el botón sea distinto de "null".
            if(senderBtn != null){
                DisableteButton(); // Llamada al método
                // Button personalization / Personalización del diseño del botón.
                currentBtn = (IconButton)senderBtn; // Convierte el botón actual a un "IconButton".
                currentBtn.BackColor = Color.FromArgb(149, 200, 190); // Cambio de color del fondo del botón.
                currentBtn.ForeColor = color; // Cambio del color de texto del botón.
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; // Alinear el texto al centro del botón.
                currentBtn.IconColor = color; // Cambio de color al ícono del botón.
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; // El texto del botón le cambia de lugar al ícono.
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; // Alinear el ícono a la derecha del botón.

                // Left border button / Borde izquierdo del botón.
                leftBorderBtn.BackColor = color; // Cambio del fondo del lado izquierdo del botón.
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y); // Cambio de ubicación del botón.
                leftBorderBtn.Visible = true; // Visibilidad como "verdadera".
                leftBorderBtn.BringToFront(); // Traer el botón hacia enfrente.

                // Icon Current Section / Icono de la sección actual.
                iconPictureBCurrentLogo.IconChar = currentBtn.IconChar; // Se le asigna al ícono de la barra el ícono del botón actual.
            }
        }

        // <--- Método #2: "DissactivateButton" ---> //
        /*
           Este método sirve para desactivar los botones del menú una vez que el cursor no se encuentre sobre
           ellos. En otras palabras, el botón vuelve a su estado original.
        */
        private void DisableteButton(){
            // Condición que verifica que el botón sea distinto de "null".
            if(currentBtn != null){
                currentBtn.BackColor = Color.CadetBlue; // Color original del botón.
                currentBtn.ForeColor = Color.White; // Cambio del color por defecto del texto del botón.
                currentBtn.TextAlign = ContentAlignment.MiddleLeft; // Alineación original del texto.
                currentBtn.IconColor = Color.White; // Cambio de color por defecto al ícono del botón.
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; // El texto del botón le cambia de lugar al ícono.
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; // Alineación por defecto del ícono.
            }
        }

        // <--- Método #3: "SecondaryForm" ---> //
        /*
           Este método nos ayudará a abrir formularios secundarios al momento de presionar los botones del menú.
           Dependiendo del botón que se presione, es el formulario que se abrirá.
        */
        private void secondForm(Form secondForm){
            if(currentSecondForm != null){
                currentSecondForm.Close();
            }

            currentSecondForm = secondForm;
            secondForm.TopLevel = false;
            secondForm.FormBorderStyle = FormBorderStyle.None;
            secondForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(secondForm);
            panelPrincipal.Tag = secondForm;
            secondForm.BringToFront();
            secondForm.Show();
            lblTitleForm.Text = secondForm.Text;
        }

        // <---------------------------------------> //
        // <---------- BOTONES / BUTTONS ----------> //
        // <---------------------------------------> //

        // <--- Botón "iconbtnMenu" (Menu / Home). ---> //
        private void iconbtnMenu_Click(object sender, EventArgs e){
            ActivateButton(sender, RGBColors.color6); // Llamada al método para diseño de botón cuando es presionado.
            /*
               Al método "SecondaryForm" se le manda como parámetro un formulario del folder
               "Forms_secundarios_para_aplicación_principal". Dicho formulario es del "Menu Principal".
            */
            secondForm(new frmMenu()); // Llamada al método "SecondaryForm" para abrir el formulario "hijo" correspondiente al botón.
        }

        // <--- Botón "iconbtnFeed" (Feedback). ---> //
        private void iconbtnFeed_Click(object sender, EventArgs e){
            ActivateButton(sender, RGBColors.color6); // Llamada al método para diseño de botón cuando es presionado.
            secondForm(new frmFeedback()); // Llamada al método "SecondaryForm" para abrir el formulario "hijo" correspondiente al botón.
        }

        // <--- Botón "iconbtnLogOut" (Log Out). ---> //
        private void iconbtnLogOut_Click(object sender, EventArgs e){
            ActivateButton(sender, RGBColors.color6); // Llamada al método para diseño de botón cuando es presionado.

            // Condición que sólo es válida sí y sólo sí el usuario presiona el botón "Yes" del MessageBox.
            if(MessageBox.Show("Are you sure you want to exit the application? \nYou'll have to log in again!", "Warning.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                Login LoginForm = new Login(); // Creación de un objeto de la clase "Login".
                LoginForm.Show(); // ".Show()" permitirá mostrar el formulario de inicio de sesión.
                this.Hide(); // ".Hide() ocultará el formulario actual (RegistrerUsers).
            }
        }

        // <--- Botón "iconPBoxClose". ---> //
        private void iconPBoxClose_Click(object sender, EventArgs e){
            // Condición que sólo es válida sí y sólo sí el usuario presiona el botón "Yes" del MessageBox.
            if (MessageBox.Show("Are you sure you want to exit the application? \nYou'll have to log in again!", "Warning.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                Login LoginForm = new Login(); // Creación de un objeto de la clase "Login".
                LoginForm.Show(); // ".Show()" permitirá mostrar el formulario de inicio de sesión.
                this.Hide(); // ".Hide() ocultará el formulario actual (RegistrerUsers).
            }
        }

        // <--- Botón "iconPBoxMaximize". ---> //
        private void iconPBoxMaximize_Click(object sender, EventArgs e){
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized; // Permite maximizar la ventana.
            else
                WindowState = FormWindowState.Normal;
        }

        // <--- Botón "iconPBoxMinimize". ---> //
        private void iconPBoxMinimize_Click(object sender, EventArgs e){
            WindowState = FormWindowState.Minimized; // Permite minimizar la ventana.
        }

        // <--- Botón "iconbtnSettings". ---> //
        private void iconbtnSettings_Click(object sender, EventArgs e){
            ActivateButton(sender, RGBColors.color6); // Llamada al método para diseño de botón cuando es presionado.
            /*
               Al método "SecondaryForm" se le manda como parámetro un formulario secundario
               de nombre "frmSettings.
            */
            secondForm(new frmSettings());
        }

        // <--- Botón "iconbtnRegistrerUsers". ---> //
        private void iconbtnRegisterUsers_Click(object sender, EventArgs e){
            ActivateButton(sender, RGBColors.color6); // Llamada al método para diseño de botón cuando es presionado.
            /*
               Al método "SecondaryForm" se le manda como parámetro un formulario secundario
               de nombre "frmUsersControl (Disponible sólo para usuarios administradores).
            */
            secondForm(new frmUsersControl());
        }

        // <--------------------------------------> //
        // <---------- EVENTOS / EVENTS ----------> //
        // <--------------------------------------> //

        // <--- Evento #1: "MouseDown" ---> //
        /*
          Este evento nos permitirá mover el formulario desde la barra de título.
        */
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e){
            // Llamada a los métodos.
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
