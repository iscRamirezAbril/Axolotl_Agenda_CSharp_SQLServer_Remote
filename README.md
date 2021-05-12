# Axolotl_Agenda_CSharp_SQLServer_Remote

<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Application_Logo.png" width = "300"/>
</p>

### ----- Descripción. ----- 📄
Proyecto Final que se entregará en la clase de "Tópicos Avanzados de Programación". Consiste en una agenda donde el usuario podrá llevar un control de sus actividades
diarias, registrando para cada una su correspondiente fecha y hora de "inicio" y "fin".

### ----- Tabla de contenidos. ----- 
En este Readme podrás encontrar la siguiente información:
- Herramientas utilizadas.
- Instalación.
- Interfaz gráfica.
- Por hacer.
- Sobre el autor.

### ----- Herramientas utilizadas. ----- 🧰
// > IDE / Editor de Código < // 💻
- [Visual Studio 2019](https://visualstudio.microsoft.com/es/)

// > Diseño < // 🎨
- Inspirado en:
[RJ Code Advance](https://www.youtube.com/watch?v=K2lgEPdhGcg&ab_channel=RJCodeAdvance)

- Font Awsome (Sitio web): https://fontawesome.com/icons?d=gallery&p=2&m=free
- Font Awsome (Repositorio de Github): https://github.com/awesome-inc/FontAwesome.Sharp

// > Base de Datos < // 
- Link de descarga: [SQL Server](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)

<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/SSMS_Download.png" width = "500"/>
</p>

### ----- Instalación. ----- 📁
Dentro de este repositorio se encuentra un archivo .rar, que contiene lo siguiente:
1. Archivo de nombre "setup".
2. Archivo .exe de nombre "Axolotl_Agenda".

<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/rar_Archives.png" />
</p>

Para ejecutar la aplicación, debe realizar lo siguiente:
1. Dar click al archivo de nombre "Axolotl_Agenda".
2. Automáticamente se abrirá el archivo "setup" y deberá presionar el botón de "Install".

<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Setup.png" width = "500"/>
</p>

3. A esperar un momento, y ¡Listo! La aplicación se ejecutará.

### ----- Interfaz gráfica. ----- 🖥️
#### <--- Login --->
<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Login.png" width = "300"/>
</p>

En esta ventana se le permitirá al usuario "iniciar sesión" a la aplicación, escribiendo su "nombre de usuario (Username)" y "contraseña (Password)". En caso de no tener una cuenta, se le dará click al segundo enlace, el cual abrirá una nueva ventana permitiendo al usuario regitrarse a la apliación.

Si a un usuario que tiene una cuenta activa se le ha olvidado la contraseña, dará click al primer enlace que se encuentra en la parte inferior de la ventana. Este abrirá una segunda ventana que permitirá llenar un formulario para la recuperación de contraseña.

#### <--- Sign Up --->
<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Sign_Up.png" width = "500"/>
</p>

En este formulario, el usuario podrá crearse una cuenta para permitir el inicio de sesión de la aplicación. Para ello, se pedirán los siguientes datos:
- Nombres.
- Apellidos.
- Nombre de usuario.
- Correo electrónico.
- Contraseña para la aplicación.

Una vez que los datos sean correctos y las contraseñas coincidan, se abrirá nuevamente la ventana de "inicio de sesión" y el usuario ya podrá utilizar la aplicación.

#### <--- Forgot Password --->
<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Forgot_Password.png" width = "400"/>
</p>

Si se presenta el caso donde el usuario haya olvidado la contraseña de su cuenta, este formulario ayudadrá a recuperarla. Para ello, los datos que debe ingresar son:
- Correo electrónico.
- Nombre de usuario.

¿Por qué se requieren esos datos? El correo electrónico es necesario para enviar al usuario un "email" donde se le enviará su contraseña, y el nombre de usuario es necesario para confirmar que el usuario se encuentre registrado en la aplicación.

#### <--- Main screen --->
<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Main_screen.png" width = "600"/>
</p>

Una vez que el usuario haya escrito sus datos de inicio sesión de manera correcta, la aplicación se abrirá. Se podrá visualizar la siguiente ventana que contiene las siguientes características:
- Username, Nombre completo y correo electrónico del usuario, así como tambien, el nombre del formulario que se enceuntra abierto, situados en la parte superior.
- En la parte "central" de la aplicación, se visualizará su logo.
- A la "izquierda" se podrán visualizar los botones de las herramientas que la aplicación ofrece, las cuales se describirán más adelante.

#### <--- Agenda --->
<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Agenda.png" width = "600"/>
</p>

Al presionar el primer botón de nombre "Menu / Home", se abrirá el formulario que cumple con la función de una agenda. En el, podrá registrar las actividades que el usuario deseé, proporcionando los siguientes datos:
- Nombre.
- Tipo de actividad; las disponibles son las siguientes:
  - Básica.
  - Escolar.
  - Entretenimiento.
  - Social.
  - Familiar.
  - Deportiva.
- Fecha y hora de inicio y fin de la actividad.

Además de agregar actividades a su agenda, también se le permitirá al usuario eliminar las actividades que ya no deseé visualizar o que ya hayan sido concluidas.

#### <--- Users Control --->
<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Users_Control.png" width = "600"/>
</p>

Este formulario sólo será visible para los usuarios que son "Administradores". En el, se podrá realizar lo siguiente:
- Visualizar los usuarios que se encuentran actualmente registrados en la aplicación.
- Registrar nuevos usuarios: en esta opción, se requieren de los mismos datos para el registro de una nueva cuenta, pero con algunos cambios:
  - Se podrá decidir si el usuario será "Administrador" o sólo un "Usuario".
  - No se requiere de una "confirmación de contraseña".
- Modificar datos de las cuentas ya registradas.
- Eliminar cuentas de usuarios.
- Buscar usuarios.

#### <--- Settings --->
<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Settings.png" width = "600"/>
</p>

Cada usuario contará con el botón de "Settings", donde será permitido modificar sus datos de la cuenta. Para ello, tendrá que presionar el link con la leyenda "edit profile". Se abrirá un pequeño formulario del lado "derecho" de la aplicación, donde el usuario podrá modificar su información. Una vez modificada, se pedirá su contraseña actual por cuestiones de seguridad y listo. Tendrá que cerrar sesión y volver a abrirla para que sus datos se actulizen correctamente.

#### <--- Feedback --->
<p align="center">
  <img src="https://github.com/iscRamirezAbril/Axolotl_Agenda_CSharp_SQLServer_Remote/blob/master/Pictures/Feedback.png" width = "600"/>
</p>

En este formulario los usuarios podrán dar una opinión y calificar la aplicación de acuerdo a su experiencia. Todos los datos son obligatorios a excepción de la opinión, la cual es opcional. Una vez que el usuario haya llenado todos los campos obligatorios, se le enviará una copia de sus respuestas al correo proporcionado en el formulario.

### ----- Por hacer. ----- 📝
- [x] Diseño del logo para la aplicación.
- [x] Diseño de la interfaz.
- [x] Programación de interfaz para un mejor diseño.
- [x] Conexión a SQL Server.
- [x] Programación de botones y la aplicación en general.
- [x] Prueba de funcionamiento y detección de errores.
- [x] Realización de un archivo .exe
- [x] Subir folder de capturas al repositorio.
- [x] Agregar imágenes al readme.
- [x] Agregar descripciones a las imágenes.

### ----- Sobre el autor. -----
#### **Nombre.**
_Ramirez Flores Abril._
#### **Perfil de Github.** :octocat:
[iscRamirezAbril](https://github.com/iscRamirezAbril)
#### **Profesión.**
_Estudiante de Ingeniería en Sistemas Computacionales._
