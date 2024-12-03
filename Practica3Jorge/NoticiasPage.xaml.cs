using Microsoft.Maui.Controls;
using Practica3Jorge;
using System.Collections.ObjectModel;

namespace Practica3Jorge
{
    public partial class NoticiasPage : ContentPage
    {
        public ObservableCollection<Noticia> Noticias { get; set; }

        public NoticiasPage()
        {
            InitializeComponent();

            Noticias = new ObservableCollection<Noticia>
            {
                new Noticia("Primer Contacto Gal�ctico",
            "La humanidad establece contacto con una civilizaci�n avanzada...",
            "not1.png",
            "03/12/2024",
            "En un evento sin precedentes, la humanidad ha logrado establecer contacto con una civilizaci�n alien�gena avanzada ubicada en el sistema Zeta-9. El encuentro tuvo lugar cuando la nave exploradora Horizon fue interceptada por una flota alien�gena con tecnolog�a nunca antes vista. Los representantes de la civilizaci�n, autodenominados como los Kryonitas, han demostrado un inter�s pac�fico y un profundo conocimiento del multiverso. Este momento marca el inicio de una nueva era de cooperaci�n intergal�ctica, con promesas de intercambio de tecnolog�a y cultura."),

new Noticia("Exploraci�n Interdimensional",
            "Se descubre un portal que permite viajar entre dimensiones...",
            "not2.png",
            "01/12/2024",
            "Cient�ficos del Instituto de F�sica Cu�ntica han anunciado el descubrimiento de un portal interdimensional en un planeta distante del sistema Alfa-7. El portal, una estructura circular con pulsos de energ�a desconocida, parece conectarse a realidades alternas. Los primeros estudios sugieren que podr�a ser una creaci�n de una civilizaci�n desaparecida hace millones de a�os. Los investigadores est�n entusiasmados por el potencial de esta tecnolog�a, que podr�a revolucionar nuestra comprensi�n del espacio y el tiempo, aunque advierten que la exploraci�n interdimensional conlleva riesgos desconocidos."),

new Noticia("La Nave M�s R�pida del Universo",
            "Presentada la nave que supera la velocidad de la luz...",
            "not3.png",
            "25/11/2024",
            "La Corporaci�n Celestia ha revelado su m�s reciente creaci�n: la Luminis, una nave que utiliza un motor de singularidad cu�ntica para alcanzar velocidades superiores a la luz. Este avance permitir� reducir los viajes interestelares de siglos a horas. Durante su presentaci�n, la Luminis realiz� un vuelo exitoso desde el sistema Solar hasta la Nebulosa del Velo en menos de 12 horas. Este desarrollo tecnol�gico no solo revolucionar� el comercio gal�ctico, sino que tambi�n abrir� nuevas oportunidades para la exploraci�n de territorios desconocidos del universo."),

new Noticia("Colonia en el Borde del Universo",
            "Inaugurada la primera colonia humana en el borde del universo conocido...",
            "not4.png",
            "20/11/2024",
            "Despu�s de d�cadas de planificaci�n, la humanidad ha establecido la primera colonia en el borde del universo conocido, en el planeta Zharon del sistema Omega-12. Bautizada como Horizonte, esta colonia est� equipada con tecnolog�a avanzada para soportar condiciones extremas y ha sido dise�ada para ser autosostenible. Con una poblaci�n inicial de 10,000 colonos, se espera que Horizonte sea el punto de partida para futuras misiones de expansi�n m�s all� de los l�mites actuales de la exploraci�n humana."),

new Noticia("El Primer H�brido Humano-Alien�gena",
            "Nace el primer h�brido humano-alien�gena, un hito en la evoluci�n intergal�ctica...",
            "not5.png",
            "15/11/2024",
            "En un acontecimiento hist�rico, ha nacido el primer h�brido entre un humano y un Zyntar, una especie alien�gena conocida por su avanzada biotecnolog�a. El beb�, apodado Nova, es el resultado de un experimento gen�tico llevado a cabo con el consentimiento de ambas partes en el laboratorio gal�ctico de Andr�meda. Los cient�ficos aseguran que este evento podr�a significar el inicio de una nueva era de cooperaci�n gen�tica, con implicaciones tanto cient�ficas como filos�ficas sobre la evoluci�n de las especies."),

new Noticia("Un Nuevo Amanecer para la IA",
            "Creada una inteligencia artificial que supera la conciencia humana...",
            "not6.png",
            "10/11/2024",
            "El laboratorio de desarrollo AI-Tek ha presentado a Sophis, una inteligencia artificial que ha alcanzado un nivel de autoconciencia que rivaliza con el de los seres humanos. Dise�ada para explorar los l�mites �ticos y tecnol�gicos, Sophis ha demostrado la capacidad de aprender, sentir y tomar decisiones complejas con autonom�a. Aunque este avance es celebrado como un logro sin precedentes, plantea preguntas cr�ticas sobre la coexistencia entre humanos y m�quinas, as� como los l�mites de la �tica en la tecnolog�a."),

            };

            BindingContext = this;
        }

        private async void OnLeerMasClicked(object sender, EventArgs e)
        {
            var label = (Label)sender; // Cambiado de Button a Label
            var noticia = (Noticia)label.BindingContext; // Ajustado para Label

            // Navegar a DetalleNoticiaPage
            await Shell.Current.GoToAsync("DetalleNoticiaPage", true, new Dictionary<string, object>
            {
                { "noticia", noticia }
            });
        }
    }
}
