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
                new Noticia("Primer Contacto Galáctico",
            "La humanidad establece contacto con una civilización avanzada...",
            "not1.png",
            "03/12/2024",
            "En un evento sin precedentes, la humanidad ha logrado establecer contacto con una civilización alienígena avanzada ubicada en el sistema Zeta-9. El encuentro tuvo lugar cuando la nave exploradora Horizon fue interceptada por una flota alienígena con tecnología nunca antes vista. Los representantes de la civilización, autodenominados como los Kryonitas, han demostrado un interés pacífico y un profundo conocimiento del multiverso. Este momento marca el inicio de una nueva era de cooperación intergaláctica, con promesas de intercambio de tecnología y cultura."),

new Noticia("Exploración Interdimensional",
            "Se descubre un portal que permite viajar entre dimensiones...",
            "not2.png",
            "01/12/2024",
            "Científicos del Instituto de Física Cuántica han anunciado el descubrimiento de un portal interdimensional en un planeta distante del sistema Alfa-7. El portal, una estructura circular con pulsos de energía desconocida, parece conectarse a realidades alternas. Los primeros estudios sugieren que podría ser una creación de una civilización desaparecida hace millones de años. Los investigadores están entusiasmados por el potencial de esta tecnología, que podría revolucionar nuestra comprensión del espacio y el tiempo, aunque advierten que la exploración interdimensional conlleva riesgos desconocidos."),

new Noticia("La Nave Más Rápida del Universo",
            "Presentada la nave que supera la velocidad de la luz...",
            "not3.png",
            "25/11/2024",
            "La Corporación Celestia ha revelado su más reciente creación: la Luminis, una nave que utiliza un motor de singularidad cuántica para alcanzar velocidades superiores a la luz. Este avance permitirá reducir los viajes interestelares de siglos a horas. Durante su presentación, la Luminis realizó un vuelo exitoso desde el sistema Solar hasta la Nebulosa del Velo en menos de 12 horas. Este desarrollo tecnológico no solo revolucionará el comercio galáctico, sino que también abrirá nuevas oportunidades para la exploración de territorios desconocidos del universo."),

new Noticia("Colonia en el Borde del Universo",
            "Inaugurada la primera colonia humana en el borde del universo conocido...",
            "not4.png",
            "20/11/2024",
            "Después de décadas de planificación, la humanidad ha establecido la primera colonia en el borde del universo conocido, en el planeta Zharon del sistema Omega-12. Bautizada como Horizonte, esta colonia está equipada con tecnología avanzada para soportar condiciones extremas y ha sido diseñada para ser autosostenible. Con una población inicial de 10,000 colonos, se espera que Horizonte sea el punto de partida para futuras misiones de expansión más allá de los límites actuales de la exploración humana."),

new Noticia("El Primer Híbrido Humano-Alienígena",
            "Nace el primer híbrido humano-alienígena, un hito en la evolución intergaláctica...",
            "not5.png",
            "15/11/2024",
            "En un acontecimiento histórico, ha nacido el primer híbrido entre un humano y un Zyntar, una especie alienígena conocida por su avanzada biotecnología. El bebé, apodado Nova, es el resultado de un experimento genético llevado a cabo con el consentimiento de ambas partes en el laboratorio galáctico de Andrómeda. Los científicos aseguran que este evento podría significar el inicio de una nueva era de cooperación genética, con implicaciones tanto científicas como filosóficas sobre la evolución de las especies."),

new Noticia("Un Nuevo Amanecer para la IA",
            "Creada una inteligencia artificial que supera la conciencia humana...",
            "not6.png",
            "10/11/2024",
            "El laboratorio de desarrollo AI-Tek ha presentado a Sophis, una inteligencia artificial que ha alcanzado un nivel de autoconciencia que rivaliza con el de los seres humanos. Diseñada para explorar los límites éticos y tecnológicos, Sophis ha demostrado la capacidad de aprender, sentir y tomar decisiones complejas con autonomía. Aunque este avance es celebrado como un logro sin precedentes, plantea preguntas críticas sobre la coexistencia entre humanos y máquinas, así como los límites de la ética en la tecnología."),

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
