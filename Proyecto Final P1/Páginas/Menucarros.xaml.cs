namespace Proyecto_Final_P1.Páginas;

public partial class Menucarros : ContentPage
{
	public Menucarros()
	{
		InitializeComponent();
        SetBackgroundColor();
    }

    private void boton4x4(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        Navigation.PushAsync(new P4x4());

    }

    private void botonpickup(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        Navigation.PushAsync(new Ppickup());
    }

    private void botonsedan(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        Navigation.PushAsync(new Psedan());
    }

    private void botonsuv(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        Navigation.PushAsync(new Psuv());
    }


    private void SetBackgroundColor()
    {
        Color backgroundColor = Colors.DarkSlateGrey; // Definir color del fondo de la página

        // Establece el color de fondo de la página
        BackgroundColor = backgroundColor;
    }
}