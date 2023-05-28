using Proyecto_Final_P1.Vehiculos;

namespace Proyecto_Final_P1.Páginas;

public partial class Psuv : ContentPage
{
	public Psuv()
	{
		InitializeComponent();
        SetBackgroundColor();
	}

    SUV suv = new SUV();
    private bool isInfoVisible1 = false;
    private void boton1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {

        VehiculoDB cardb = new VehiculoDB();
        suv.marca = "Marca: Ford";
        suv.modelo = "Modelo: Escape";
        suv.color = "Color: Escape";
        suv.anio = 2022;
        suv.placa = "Placa : ABC 124";
        suv.tipo = "Tipo: SUV compacta";
        cardb.insertarvehiculos((IVehiculo)suv);

        MarcaLabel1.Text = suv.marca;
        ModeloLabel1.Text = suv.modelo;
        ColorLabel1.Text = suv.color;
        AnioLabel1.Text = suv.anio.ToString();
        PlacaLabel1.Text = suv.placa;
        TipoLabel1.Text = suv.tipo;

        isInfoVisible1 = !isInfoVisible1; // Invierte el estado actual de visibilidad

        InfoStackLayout1.IsVisible = isInfoVisible1;
    }

    private bool isInfoVisible2 = false;
    private void boton2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        VehiculoDB cardb = new VehiculoDB();
        suv.marca = "Marca: BMW";
        suv.modelo = "Modelo: X5";
        suv.color = "Color: Blanco";
        suv.anio = 2021;
        suv.placa = "Placa : DEF 455";
        suv.tipo = "Tipo: SUV de lujo";
        cardb.insertarvehiculos((IVehiculo)suv);

        MarcaLabel2.Text = suv.marca;
        ModeloLabel2.Text = suv.modelo;
        ColorLabel2.Text = suv.color;
        AnioLabel2.Text = suv.anio.ToString();
        PlacaLabel2.Text = suv.placa;
        TipoLabel2.Text = suv.tipo;

        isInfoVisible2 = !isInfoVisible2; // Invierte el estado actual de visibilidad

        InfoStackLayout2.IsVisible = isInfoVisible2;
    }

    private bool isInfoVisible3 = false;
    private void boton3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        VehiculoDB cardb = new VehiculoDB();
        suv.marca = "Marca: Toyota";
        suv.modelo = "Modelo: Highlander";
        suv.color = "Color: Plateado";
        suv.anio = 2020;
        suv.placa = "Placa : GHI 789";
        suv.tipo = "Tipo: SUV de tamaño medio";
        cardb.insertarvehiculos((IVehiculo)suv);

        MarcaLabel3.Text = suv.marca;
        ModeloLabel3.Text = suv.modelo;
        ColorLabel3.Text = suv.color;
        AnioLabel3.Text = suv.anio.ToString();
        PlacaLabel3.Text = suv.placa;
        TipoLabel3.Text = suv.tipo;

        isInfoVisible3 = !isInfoVisible3; // Invierte el estado actual de visibilidad

        InfoStackLayout3.IsVisible = isInfoVisible3;
    }

    private void botonencender1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout1.IsVisible = true;
        suv.encender = "El carro esta encendido.";
        encenderLabel1.Text = suv.encender;
    }

    private void botonbocina1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout1.IsVisible = true;
        suv.bocina = "La bocina esta sonando.";
        bocinaLabel1.Text = suv.bocina;
    }

    private void botonapagar1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        suv.apagar = "El carro esta apagado.";
        apagarLabel1.Text = suv.apagar;
        InfoStackLayout1.IsVisible = true;
    }

    private void botonencender2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout2.IsVisible = true;
        suv.encender = "El carro esta encendido.";
        encenderLabel2.Text = suv.encender;
    }

    private void botonbocina2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout2.IsVisible = true;
        suv.bocina = "La bocina esta sonando..";
        bocinaLabel2.Text = suv.bocina;
    }

    private void botonapagar2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        suv.apagar = "El carro esta apagado.";
        apagarLabel2.Text = suv.apagar;
        InfoStackLayout2.IsVisible = true;
    }

    private void botonencender3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout3.IsVisible = true;
        suv.encender = "El carro esta encendido.";
        encenderLabel3.Text = suv.encender;
    }

    private void botonbocina3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout3.IsVisible = true;
        suv.bocina = "La bocina esta sonando..";
        bocinaLabel3.Text = suv.bocina;
    }

    private void botonapagar3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        suv.apagar = "El carro esta apagado.";
        apagarLabel3.Text = suv.apagar;
        InfoStackLayout3.IsVisible = true;
    }


    private void SetBackgroundColor()
    {
        Color backgroundColor = Colors.DarkGoldenrod; // Definir color del fondo de la página

        // Establece el color de fondo de la página
        BackgroundColor = backgroundColor;
    }
}