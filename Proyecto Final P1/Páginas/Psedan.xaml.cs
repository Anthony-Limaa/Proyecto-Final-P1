using Proyecto_Final_P1.Vehiculos;

namespace Proyecto_Final_P1.Páginas;

public partial class Psedan : ContentPage
{
	public Psedan()
	{
		InitializeComponent();
        SetBackgroundColor();
	}

    Sedan sedan = new Sedan();
    private bool isInfoVisible1 = false;
    private void boton1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {

        VehiculoDB cardb = new VehiculoDB();
        sedan.marca = "Marca: Honda";
        sedan.modelo = "Modelo: Civic";
        sedan.color = "Color: Plateado";
        sedan.anio = 2022;
        sedan.placa = "Placa : JKL 012";
        sedan.tipo = "Tipo: Sedán compacto";
        cardb.insertarvehiculos((IVehiculo)sedan);

        MarcaLabel1.Text = sedan.marca;
        ModeloLabel1.Text = sedan.modelo;
        ColorLabel1.Text = sedan.color;
        AnioLabel1.Text = sedan.anio.ToString();
        PlacaLabel1.Text = sedan.placa;
        TipoLabel1.Text = sedan.tipo;

        isInfoVisible1 = !isInfoVisible1; // Invierte el estado actual de visibilidad

        InfoStackLayout1.IsVisible = isInfoVisible1;
    }

    private bool isInfoVisible2 = false;
    private void boton2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        VehiculoDB cardb = new VehiculoDB();
        sedan.marca = "Marca: BMW";
        sedan.modelo = "Modelo: Serie 3";
        sedan.color = "Color: Negro";
        sedan.anio = 2021;
        sedan.placa = "Placa : MNO 345";
        sedan.tipo = "Tipo: Sedán de lujo";
        cardb.insertarvehiculos((IVehiculo)sedan);

        MarcaLabel2.Text = sedan.marca;
        ModeloLabel2.Text = sedan.modelo;
        ColorLabel2.Text = sedan.color;
        AnioLabel2.Text = sedan.anio.ToString();
        PlacaLabel2.Text = sedan.placa;
        TipoLabel2.Text = sedan.tipo;

        isInfoVisible2 = !isInfoVisible2; // Invierte el estado actual de visibilidad

        InfoStackLayout2.IsVisible = isInfoVisible2;
    }

    private bool isInfoVisible3 = false;
    private void boton3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        VehiculoDB cardb = new VehiculoDB();
        sedan.marca = "Marca: Volkswagen";
        sedan.modelo = "Modelo: Jetta";
        sedan.color = "Color: Blanco";
        sedan.anio = 2020;
        sedan.placa = "Placa : PQR 678";
        sedan.tipo = "Tipo: Sedán de tamaño medio";
        cardb.insertarvehiculos((IVehiculo)sedan);

        MarcaLabel3.Text = sedan.marca;
        ModeloLabel3.Text = sedan.modelo;
        ColorLabel3.Text = sedan.color;
        AnioLabel3.Text = sedan.anio.ToString();
        PlacaLabel3.Text = sedan.placa;
        TipoLabel3.Text = sedan.tipo;

        isInfoVisible3 = !isInfoVisible3; // Invierte el estado actual de visibilidad

        InfoStackLayout3.IsVisible = isInfoVisible3;
    }

    private void botonencender1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout1.IsVisible = true;
        sedan.encender = "El carro esta encendido.";
        encenderLabel1.Text = sedan.encender;
    }

    private void botonbocina1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout1.IsVisible = true;
        sedan.bocina = "La bocina esta sonando.";
        bocinaLabel1.Text = sedan.bocina;
    }

    private void botonapagar1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        sedan.apagar = "El carro esta apagado.";
        apagarLabel1.Text = sedan.apagar;
        InfoStackLayout1.IsVisible = true;
    }

    private void botonencender2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout2.IsVisible = true;
        sedan.encender = "El carro esta encendido.";
        encenderLabel2.Text = sedan.encender;
    }

    private void botonbocina2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout2.IsVisible = true;
        sedan.bocina = "La bocina esta sonando..";
        bocinaLabel2.Text = sedan.bocina;
    }

    private void botonapagar2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        sedan.apagar = "El carro esta apagado.";
        apagarLabel2.Text = sedan.apagar;
        InfoStackLayout2.IsVisible = true;
    }

    private void botonencender3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout3.IsVisible = true;
        sedan.encender = "El carro esta encendido.";
        encenderLabel3.Text = sedan.encender;
    }

    private void botonbocina3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout3.IsVisible = true;
        sedan.bocina = "La bocina esta sonando..";
        bocinaLabel3.Text = sedan.bocina;
    }

    private void botonapagar3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        sedan.apagar = "El carro esta apagado.";
        apagarLabel3.Text = sedan.apagar;
        InfoStackLayout3.IsVisible = true;
    }



    private void SetBackgroundColor()
    {
        Color backgroundColor = Colors.BlueViolet; // Definir color del fondo de la página

        // Establece el color de fondo de la página
        BackgroundColor = backgroundColor;
    }
}