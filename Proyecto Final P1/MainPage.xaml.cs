using Proyecto_Final_P1.Páginas;

namespace Proyecto_Final_P1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SetBackgroundColor();
    }
    VehiculoDB cardb = new VehiculoDB();

    private void botoniniciar(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón "Inciar el Programa"
    {
        Navigation.PushAsync(new Menucarros());
        
        cardb.creartablavehiculo();
    }

    private void botonsalir(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }

    private void botoneliminar(object sender, EventArgs e)
    {
        cardb.eliminartablavehiculo();
    }

    private void SetBackgroundColor()
    {
        Color backgroundColor = Colors.DarkSlateGrey; // Definir color del fondo de la página

        // Establece el color de fondo de la página
        BackgroundColor = backgroundColor;
    }
}

