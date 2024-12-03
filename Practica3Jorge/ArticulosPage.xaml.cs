using Microsoft.Maui.Controls;
using Practica3Jorge.Models;
using System.Collections.ObjectModel;

namespace Practica3Jorge;

public partial class ArticulosPage : ContentPage
{
    // Lista observable de artículos
    public ObservableCollection<Articulo> Articulos { get; set; }

    public ArticulosPage()
    {
        InitializeComponent();

        // Datos de ejemplo
        Articulos = new ObservableCollection<Articulo>
        {
            new Articulo("Símbolo del Origen Estelar",
"Representación holográfica de la energía primordial que dio origen a los universos en la teoría del Multiverso Eterno. Este símbolo es reverenciado como el \"punto cero\" de la creación misma.\n\nDatos Importantes:\n\nLínea Temporal nº: 1\nUniverso: Alfa-Primordial\nGalaxia: Núcleo Central\nAño: 0",
9999.99m, "simbolodeorigenestelarsf.png"),

new Articulo("Pirámide del Horizonte Infinito",
"Una estructura geométrica que simboliza la conexión entre el cosmos y el subespacio. Descubierta en el planeta N’Karr, emite dos energías opuestas que alimentan las civilizaciones que la rodean.\n\nDatos Importantes:\n\nLínea Temporal nº: 702\nUniverso: Delta-6\nGalaxia: Lira Roja\nAño: 3001",
7850.00m, "piramidedelhorizonteinfinitosf.png"),

new Articulo("Emisario Galáctico",
"Un retrato del último embajador de los Luminaris, una raza de pacificadores que negoció el fin de la Guerra Cósmica en el universo Beta-9. Su mirada transmite la sabiduría acumulada a través de milenios.\n\nDatos Importantes:\n\nLínea Temporal nº: 33\nUniverso: Beta-9\nGalaxia: Nebulosa de Cristal\nAño: 12000",
11000.00m, "emisariogalacticosf.png"),

new Articulo("Cibernáutica Cranial",
"El \"Cerebro Cibernáutico\" es una reliquia de los Cibernétides, una civilización extinta que fusionó orgánico y mecánico. Este dispositivo almacenaba las mentes de los mayores científicos, permitiéndoles operar incluso después de su muerte física.\n\nDatos Importantes:\n\nLínea Temporal nº: 910\nUniverso: Omega-12\nGalaxia: Fénix Dorado\nAño: 5412",
8999.99m, "cibernauticacranialsf.png"),

new Articulo("Modelo Atómico Vintage",
"Representación del \"Átomo Primordial\", el primer modelo atómico descubierto en el año 3150 de la línea temporal terrestre tras el contacto interdimensional con el Consejo Científico de Andrómeda. Sus órbitas brillantes revelan energías que desafiaron las leyes conocidas de la física.\n\nDatos Importantes:\n\nLínea Temporal nº: 427\nUniverso: Sigma-3\nGalaxia: Andrómeda\nAño: 3150",
7200.00m, "modeloatomicovintagesf.png"),

new Articulo("Busto Cósmico de Budha",
"Última representación del Budha Tecnológico del año 2392 de la galaxia Novo Prometeo, universo Beta-11x. Se dice que este busto fue creado para conmemorar la unión entre las razas humanoides y las entidades cibernéticas tras la Gran Convergencia.\n\nDatos Importantes:\n\nLínea Temporal nº: 123\nUniverso: Beta-11x\nGalaxia: Novo Prometeo\nAño: 2392",
9500.00m, "bustocosmicosf.png"),

new Articulo("Cráneo Anatómico",
"El cráneo pertenece a la primera especie híbrida registrada en el año 4025, una mezcla de humanos y los llamados \"Sintelianos\", provenientes del universo Delta-4. Este espécimen fue descubierto en un laboratorio secreto durante la extinción masiva de Homo Sapiens.\n\nDatos Importantes:\n\nLínea Temporal nº: 89\nUniverso: Delta-4\nGalaxia: Cuásar Negro\nAño: 4025",
8500.00m, "craneoanatomicosf.png"),

new Articulo("Meteorito Luminoso",
"Fragmento del \"Cometa de Éter\", conocido por cruzar dimensiones en el año 7908. Su núcleo brillante contiene una energía llamada \"luzmateria\", utilizada para desarrollar tecnologías de viaje interdimensional.\n\nDatos Importantes:\n\nLínea Temporal nº: 792\nUniverso: Alfa-8\nGalaxia: Nebulosa del Éter\nAño: 7908",
9800.00m, "meteoritoluminososf.png"),

new Articulo("Cerebro en Frasco",
"El \"Cerebro de Zyntax\" pertenece al científico más brillante del universo Epsilon-19, que decidió conservar su mente en un frasco en el año 5211. Este cerebro aún emite pulsos eléctricos capaces de resolver enigmas complejos.\n\nDatos Importantes:\n\nLínea Temporal nº: 215\nUniverso: Epsilon-19\nGalaxia: Espiral de Cristal\nAño: 5211",
7600.00m, "cerebroenfrascosf.png"),

new Articulo("Cerebro Energético",
"Representación holográfica de la \"Red Mental Colectiva\" creada por los Krixonitas, una raza avanzada de la galaxia Zelta durante el año 10.001. Este cerebro encapsula el conocimiento acumulado de más de mil civilizaciones.\n\nDatos Importantes:\n\nLínea Temporal nº: 5\nUniverso: Omega-7\nGalaxia: Zelta\nAño: 10.001",
8800.00m, "cerebroenergeticosf.png"),

new Articulo("Brazo Robótico",
"El \"Brazo de Kaelon\" es una reliquia del primer androide consciente creado en el año 4100 en el universo Tau-12. Este brazo aún contiene tecnología secreta que se rumorea puede desatar el caos si es activada.\n\nDatos Importantes:\n\nLínea Temporal nº: 302\nUniverso: Tau-12\nGalaxia: Fénix Oscuro\nAño: 4100",
9700.00m, "brazoroboticosf.png"),

new Articulo("Tubos de Ensayo",
"Conocidos como los \"Tubos de Uronix\", estos recipientes contienen la última fórmula química creada en el universo Kappa-5. Se dice que una de estas fórmulas puede generar vida instantáneamente.\n\nDatos Importantes:\n\nLínea Temporal nº: 187\nUniverso: Kappa-5\nGalaxia: Estrella Fragmentada\nAño: 2907",
8900.00m, "tubosdeensayosf.png"),

new Articulo("Destilador de Etherium",
"Este destilador fue diseñado para separar el éter puro de los elementos cósmicos residuales. Fue creado en el año 4520 por los Alquimistas del Vacío, una civilización que exploraba la conversión de materia en energía pura para alimentar portales dimensionales.\n\nDatos Importantes:\n\nLínea Temporal nº: 451\nUniverso: Zeta-13\nGalaxia: Espiral de Hiperión\nAño: 4520",
9100.00m, "destiladordeetheriumsf.png"),


        };

        

        // Asignar el contexto de datos para la vinculación
        BindingContext = this;
    }


    private async void OnImageTapped(object sender, EventArgs e)
    {
        var image = (Image)sender;
        var articulo = (Articulo)image.BindingContext;

        // Navegar a la página de detalles
        await Shell.Current.GoToAsync("DetalleArticuloPage", true, new Dictionary<string, object>
    {
        { "articulo", articulo }
    });
    }

}


