using Microsoft.Maui.Controls;
using Practica3Jorge.Models;
using System.Collections.ObjectModel;

namespace Practica3Jorge;

public partial class ArticulosPage : ContentPage
{
    // Lista observable de art�culos
    public ObservableCollection<Articulo> Articulos { get; set; }

    public ArticulosPage()
    {
        InitializeComponent();

        // Datos de ejemplo
        Articulos = new ObservableCollection<Articulo>
        {
            new Articulo("S�mbolo del Origen Estelar",
"Representaci�n hologr�fica de la energ�a primordial que dio origen a los universos en la teor�a del Multiverso Eterno. Este s�mbolo es reverenciado como el \"punto cero\" de la creaci�n misma.\n\nDatos Importantes:\n\nL�nea Temporal n�: 1\nUniverso: Alfa-Primordial\nGalaxia: N�cleo Central\nA�o: 0",
9999.99m, "simbolodeorigenestelarsf.png"),

new Articulo("Pir�mide del Horizonte Infinito",
"Una estructura geom�trica que simboliza la conexi�n entre el cosmos y el subespacio. Descubierta en el planeta N�Karr, emite dos energ�as opuestas que alimentan las civilizaciones que la rodean.\n\nDatos Importantes:\n\nL�nea Temporal n�: 702\nUniverso: Delta-6\nGalaxia: Lira Roja\nA�o: 3001",
7850.00m, "piramidedelhorizonteinfinitosf.png"),

new Articulo("Emisario Gal�ctico",
"Un retrato del �ltimo embajador de los Luminaris, una raza de pacificadores que negoci� el fin de la Guerra C�smica en el universo Beta-9. Su mirada transmite la sabidur�a acumulada a trav�s de milenios.\n\nDatos Importantes:\n\nL�nea Temporal n�: 33\nUniverso: Beta-9\nGalaxia: Nebulosa de Cristal\nA�o: 12000",
11000.00m, "emisariogalacticosf.png"),

new Articulo("Cibern�utica Cranial",
"El \"Cerebro Cibern�utico\" es una reliquia de los Cibern�tides, una civilizaci�n extinta que fusion� org�nico y mec�nico. Este dispositivo almacenaba las mentes de los mayores cient�ficos, permiti�ndoles operar incluso despu�s de su muerte f�sica.\n\nDatos Importantes:\n\nL�nea Temporal n�: 910\nUniverso: Omega-12\nGalaxia: F�nix Dorado\nA�o: 5412",
8999.99m, "cibernauticacranialsf.png"),

new Articulo("Modelo At�mico Vintage",
"Representaci�n del \"�tomo Primordial\", el primer modelo at�mico descubierto en el a�o 3150 de la l�nea temporal terrestre tras el contacto interdimensional con el Consejo Cient�fico de Andr�meda. Sus �rbitas brillantes revelan energ�as que desafiaron las leyes conocidas de la f�sica.\n\nDatos Importantes:\n\nL�nea Temporal n�: 427\nUniverso: Sigma-3\nGalaxia: Andr�meda\nA�o: 3150",
7200.00m, "modeloatomicovintagesf.png"),

new Articulo("Busto C�smico de Budha",
"�ltima representaci�n del Budha Tecnol�gico del a�o 2392 de la galaxia Novo Prometeo, universo Beta-11x. Se dice que este busto fue creado para conmemorar la uni�n entre las razas humanoides y las entidades cibern�ticas tras la Gran Convergencia.\n\nDatos Importantes:\n\nL�nea Temporal n�: 123\nUniverso: Beta-11x\nGalaxia: Novo Prometeo\nA�o: 2392",
9500.00m, "bustocosmicosf.png"),

new Articulo("Cr�neo Anat�mico",
"El cr�neo pertenece a la primera especie h�brida registrada en el a�o 4025, una mezcla de humanos y los llamados \"Sintelianos\", provenientes del universo Delta-4. Este esp�cimen fue descubierto en un laboratorio secreto durante la extinci�n masiva de Homo Sapiens.\n\nDatos Importantes:\n\nL�nea Temporal n�: 89\nUniverso: Delta-4\nGalaxia: Cu�sar Negro\nA�o: 4025",
8500.00m, "craneoanatomicosf.png"),

new Articulo("Meteorito Luminoso",
"Fragmento del \"Cometa de �ter\", conocido por cruzar dimensiones en el a�o 7908. Su n�cleo brillante contiene una energ�a llamada \"luzmateria\", utilizada para desarrollar tecnolog�as de viaje interdimensional.\n\nDatos Importantes:\n\nL�nea Temporal n�: 792\nUniverso: Alfa-8\nGalaxia: Nebulosa del �ter\nA�o: 7908",
9800.00m, "meteoritoluminososf.png"),

new Articulo("Cerebro en Frasco",
"El \"Cerebro de Zyntax\" pertenece al cient�fico m�s brillante del universo Epsilon-19, que decidi� conservar su mente en un frasco en el a�o 5211. Este cerebro a�n emite pulsos el�ctricos capaces de resolver enigmas complejos.\n\nDatos Importantes:\n\nL�nea Temporal n�: 215\nUniverso: Epsilon-19\nGalaxia: Espiral de Cristal\nA�o: 5211",
7600.00m, "cerebroenfrascosf.png"),

new Articulo("Cerebro Energ�tico",
"Representaci�n hologr�fica de la \"Red Mental Colectiva\" creada por los Krixonitas, una raza avanzada de la galaxia Zelta durante el a�o 10.001. Este cerebro encapsula el conocimiento acumulado de m�s de mil civilizaciones.\n\nDatos Importantes:\n\nL�nea Temporal n�: 5\nUniverso: Omega-7\nGalaxia: Zelta\nA�o: 10.001",
8800.00m, "cerebroenergeticosf.png"),

new Articulo("Brazo Rob�tico",
"El \"Brazo de Kaelon\" es una reliquia del primer androide consciente creado en el a�o 4100 en el universo Tau-12. Este brazo a�n contiene tecnolog�a secreta que se rumorea puede desatar el caos si es activada.\n\nDatos Importantes:\n\nL�nea Temporal n�: 302\nUniverso: Tau-12\nGalaxia: F�nix Oscuro\nA�o: 4100",
9700.00m, "brazoroboticosf.png"),

new Articulo("Tubos de Ensayo",
"Conocidos como los \"Tubos de Uronix\", estos recipientes contienen la �ltima f�rmula qu�mica creada en el universo Kappa-5. Se dice que una de estas f�rmulas puede generar vida instant�neamente.\n\nDatos Importantes:\n\nL�nea Temporal n�: 187\nUniverso: Kappa-5\nGalaxia: Estrella Fragmentada\nA�o: 2907",
8900.00m, "tubosdeensayosf.png"),

new Articulo("Destilador de Etherium",
"Este destilador fue dise�ado para separar el �ter puro de los elementos c�smicos residuales. Fue creado en el a�o 4520 por los Alquimistas del Vac�o, una civilizaci�n que exploraba la conversi�n de materia en energ�a pura para alimentar portales dimensionales.\n\nDatos Importantes:\n\nL�nea Temporal n�: 451\nUniverso: Zeta-13\nGalaxia: Espiral de Hiperi�n\nA�o: 4520",
9100.00m, "destiladordeetheriumsf.png"),

new Articulo(
    "Ticket para el Psiquiatra",
  "Agradecemos tu visita y tus compras en nuestra tienda. Sin embargo, tras analizar detenidamente los patrones de compra de nuestros clientes, hemos llegado a la conclusi�n de que adquirir productos en esta tienda suele ser indicio de cierto... desbalance emocional.\nPor ello, y como muestra de nuestro compromiso con tu bienestar, te ofrecemos este ticket que incluye una cita programada con un psiquiatra de confianza.",
    49.99m,
    "ticketpsiatrico.png",
    new List<string>
    {
        "Gracias al Dr. Jonathan Crane, finalmente logr� enfrentar mis miedos y recuperar el control de mi vida. �Es un verdadero genio!",
        "No estaba seguro de ir, pero tras mi primera sesi�n con el Dr. Stephen Strange, siento que el multiverso no tiene tantos secretos para m�. �Incre�ble profesional!",
        "Mi vida ha dado un giro completo. De no entender por qu� coleccionaba objetos extra�os, ahora tengo claridad mental. �Recomiendo totalmente esta experiencia!",
        "El Dr. Charles Xavier me ayud� a conectar con mi mente como nunca antes. Ha sido un proceso revelador y estoy agradecido por esta oportunidad.",
        "Desde que us� este ticket, siento que mis d�as tienen m�s sentido. No s� si es magia o ciencia, pero ha funcionado.",
        "El Dr. Harleen Quinzel me escuch� como nadie antes. Fue algo liberador, aunque creo que terminar� visit�ndola m�s de lo planeado.",
        "Mi vida estaba llena de caos hasta que decid� usar este ticket. Ahora, cada decisi�n que tomo tiene un prop�sito claro. �Una inversi�n incre�ble!",
        "Nunca pens� que una consulta con el Dr. Victor Fries cambiar�a mi perspectiva sobre el fr�o de la vida. �Recomendado para quienes necesitan calma!"
    }
),


        };

        

        // Asignar el contexto de datos para la vinculaci�n
        BindingContext = this;
    }


    private async void OnImageTapped(object sender, EventArgs e)
    {
        var image = (Image)sender;
        var articulo = (Articulo)image.BindingContext;

        // Navegar a la p�gina de detalles
        await Shell.Current.GoToAsync("DetalleArticuloPage", true, new Dictionary<string, object>
    {
        { "articulo", articulo }
    });
    }


    private void OnAgregarCarritoClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var articulo = (Articulo)button.BindingContext;

        // Agregar al carrito
        CarritoManager.AgregarArticulo(articulo);

        // Mostrar el mensaje con la cantidad actualizada
        DisplayAlert("Carrito", $"{articulo.Nombre} a�adido al carrito. Total art�culos: {CarritoManager.ObtenerCantidadArticulos()}", "OK");
    }
}


