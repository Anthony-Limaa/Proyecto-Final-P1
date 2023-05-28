using Proyecto_Final_P1.Vehiculos;

namespace Proyecto_Final_P1.Páginas;

public partial class Ppickup : ContentPage
{
    public Ppickup()
    {
        InitializeComponent();
        SetBackgroundColor();
    }
    PickUp pickup = new PickUp();

    private bool isInfoVisible1 = false;
    private void boton1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {

        VehiculoDB cardb = new VehiculoDB();

        pickup.marca = "Marca: Ford";
        pickup.modelo = "Modelo: F-150";
        pickup.color = "Color: Azul";
        pickup.anio = 2019;
        pickup.placa = "Placa : ABC 123";
        pickup.tipo = "Tipo: Pickup de tamaño completo";
        cardb.insertarvehiculos((IVehiculo)pickup);

        MarcaLabel1.Text = pickup.marca;
        ModeloLabel1.Text = pickup.modelo;
        ColorLabel1.Text = pickup.color;
        AnioLabel1.Text = pickup.anio.ToString();
        PlacaLabel1.Text = pickup.placa;
        TipoLabel1.Text = pickup.tipo;

        isInfoVisible1 = !isInfoVisible1; // Invierte el estado actual de visibilidad

        InfoStackLayout1.IsVisible = isInfoVisible1;
    }

    private bool isInfoVisible2 = false;
    private void boton2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        VehiculoDB cardb = new VehiculoDB();
        pickup.marca = "Marca: Chevrolet";
        pickup.modelo = "Modelo: Silverado 1500";
        pickup.color = "Color: Negro";
        pickup.anio = 2020;
        pickup.placa = "Placa : DEF 456";
        pickup.tipo = "Tipo: Pickup de tamaño completo";
        cardb.insertarvehiculos((IVehiculo)pickup);

        MarcaLabel2.Text = pickup.marca;
        ModeloLabel2.Text = pickup.modelo;
        ColorLabel2.Text = pickup.color;
        AnioLabel2.Text = pickup.anio.ToString();
        PlacaLabel2.Text = pickup.placa;
        TipoLabel2.Text = pickup.tipo;

        isInfoVisible2 = !isInfoVisible2; // Invierte el estado actual de visibilidad

        InfoStackLayout2.IsVisible = isInfoVisible2;
    }

    private bool isInfoVisible3 = false;
    private void boton3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        VehiculoDB cardb = new VehiculoDB();
        pickup.marca = "Marca: Toyota";
        pickup.modelo = "Modelo: Tacoma";
        pickup.color = "Color: Rojo";
        pickup.anio = 2018;
        pickup.placa = "Placa : GHI 789";
        pickup.tipo = "Tipo: Pickup mediana";
        cardb.insertarvehiculos((IVehiculo)pickup);

        MarcaLabel3.Text = pickup.marca;
        ModeloLabel3.Text = pickup.modelo;
        ColorLabel3.Text = pickup.color;
        AnioLabel3.Text = pickup.anio.ToString();
        PlacaLabel3.Text = pickup.placa;
        TipoLabel3.Text = pickup.tipo;

        isInfoVisible3 = !isInfoVisible3; // Invierte el estado actual de visibilidad

        InfoStackLayout3.IsVisible = isInfoVisible3;
    }

    private void botonencender1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout1.IsVisible = true;
        pickup.encender = "El carro esta encendido.";
        encenderLabel1.Text = pickup.encender;
    }

    private void botonbocina1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout1.IsVisible = true;
        pickup.bocina = "La bocina esta sonando.";
        bocinaLabel1.Text = pickup.bocina;
    }

    private void botonapagar1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        pickup.apagar = "El carro esta apagado.";
        apagarLabel1.Text = pickup.apagar;
        InfoStackLayout1.IsVisible = true;
    }

    private void botonencender2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout2.IsVisible = true;
        pickup.encender = "El carro esta encendido.";
        encenderLabel2.Text = pickup.encender;
    }

    private void botonbocina2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout2.IsVisible = true;
        pickup.bocina = "La bocina esta sonando..";
        bocinaLabel2.Text = pickup.bocina;
    }

    private void botonapagar2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        pickup.apagar = "El carro esta apagado.";
        apagarLabel2.Text = pickup.apagar;
        InfoStackLayout2.IsVisible = true;
    }

    private void botonencender3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout3.IsVisible = true;
        pickup.encender = "El carro esta encendido.";
        encenderLabel3.Text = pickup.encender;
    }

    private void botonbocina3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout3.IsVisible = true;
        pickup.bocina = "La bocina esta sonando..";
        bocinaLabel3.Text = pickup.bocina;
    }

    private void botonapagar3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        pickup.apagar = "El carro esta apagado.";
        apagarLabel3.Text = pickup.apagar;
        InfoStackLayout3.IsVisible = true;
    }


    private void SetBackgroundColor()
    {
        Color backgroundColor = Colors.Green; // Definir color del fondo de la página

        // Establece el color de fondo de la página
        BackgroundColor = backgroundColor;
    }
}
