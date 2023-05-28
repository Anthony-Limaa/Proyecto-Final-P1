using Proyecto_Final_P1.Vehiculos;

namespace Proyecto_Final_P1.Páginas;

public partial class P4x4 : ContentPage
{
    public P4x4()
    {
        InitializeComponent();
        SetBackgroundColor();
    }

    _4x4 cuatroporcuatro = new _4x4();

    private bool isInfoVisible1 = false;
    private void boton1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {

        VehiculoDB cardb = new VehiculoDB();
        cuatroporcuatro.marca = "Marca: Jeep";
        cuatroporcuatro.modelo = "Modelo: Wrangler";
        cuatroporcuatro.color = "Color: Verde";
        cuatroporcuatro.anio = 2023;
        cuatroporcuatro.placa = "Placa : STU 901";
        cuatroporcuatro.tipo = "Tipo: SUV 4x4";
        cardb.insertarvehiculos((IVehiculo)cuatroporcuatro);

        MarcaLabel1.Text = cuatroporcuatro.marca;
        ModeloLabel1.Text = cuatroporcuatro.modelo;
        ColorLabel1.Text = cuatroporcuatro.color;
        AnioLabel1.Text = cuatroporcuatro.anio.ToString();
        PlacaLabel1.Text = cuatroporcuatro.placa;
        TipoLabel1.Text = cuatroporcuatro.tipo;


        isInfoVisible1 = !isInfoVisible1; // Invierte el estado actual de visibilidad

        InfoStackLayout1.IsVisible = isInfoVisible1;

    }

    private bool isInfoVisible2 = false;
    private void boton2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        VehiculoDB cardb = new VehiculoDB();
        cuatroporcuatro.marca = "Marca: Land Rover";
        cuatroporcuatro.modelo = "Modelo: Range Rover Sport";
        cuatroporcuatro.color = "Color: Gris";
        cuatroporcuatro.anio = 2022;
        cuatroporcuatro.placa = "Placa : VWX 234";
        cuatroporcuatro.tipo = "Tipo: SUV de lujo 4x4";
        cardb.insertarvehiculos((IVehiculo)cuatroporcuatro);

        MarcaLabel2.Text = cuatroporcuatro.marca;
        ModeloLabel2.Text = cuatroporcuatro.modelo;
        ColorLabel2.Text = cuatroporcuatro.color;
        AnioLabel2.Text = cuatroporcuatro.anio.ToString();
        PlacaLabel2.Text = cuatroporcuatro.placa;
        TipoLabel2.Text = cuatroporcuatro.tipo;

        isInfoVisible2 = !isInfoVisible2; // Invierte el estado actual de visibilidad

        InfoStackLayout2.IsVisible = isInfoVisible2;
    }
    private bool isInfoVisible3 = false;
    private void boton3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        VehiculoDB cardb = new VehiculoDB();
        cuatroporcuatro.marca = "Marca: Toyota";
        cuatroporcuatro.modelo = "Modelo: 4Runner";
        cuatroporcuatro.color = "Color: Negro";
        cuatroporcuatro.anio = 2021;
        cuatroporcuatro.placa = "Placa : YZA 567";
        cuatroporcuatro.tipo = "Tipo: SUV mediana 4x4";
        cardb.insertarvehiculos((IVehiculo)cuatroporcuatro);

        MarcaLabel3.Text = cuatroporcuatro.marca;
        ModeloLabel3.Text = cuatroporcuatro.modelo;
        ColorLabel3.Text = cuatroporcuatro.color;
        AnioLabel3.Text = cuatroporcuatro.anio.ToString();
        PlacaLabel3.Text = cuatroporcuatro.placa;
        TipoLabel3.Text = cuatroporcuatro.tipo;

       
        isInfoVisible3 = !isInfoVisible3; // Invierte el estado actual de visibilidad

        InfoStackLayout3.IsVisible = isInfoVisible3;
    }

    private void botonencender1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout1.IsVisible = true;
        cuatroporcuatro.encender = "El carro esta encendido.";
        encenderLabel1.Text = cuatroporcuatro.encender;
    }

    private void botonbocina1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout1.IsVisible = true;
        cuatroporcuatro.bocina = "La bocina esta sonando.";
        bocinaLabel1.Text = cuatroporcuatro.bocina;
    }

    private void botonapagar1(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        cuatroporcuatro.apagar = "El carro esta apagado.";
        apagarLabel1.Text = cuatroporcuatro.apagar;
        InfoStackLayout1.IsVisible = true;
    }

    private void botonencender2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout2.IsVisible = true;
        cuatroporcuatro.encender = "El carro esta encendido.";
        encenderLabel2.Text = cuatroporcuatro.encender;
    }

    private void botonbocina2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout2.IsVisible = true;
        cuatroporcuatro.bocina = "La bocina esta sonando..";
        bocinaLabel2.Text = cuatroporcuatro.bocina;
    }

    private void botonapagar2(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        cuatroporcuatro.apagar = "El carro esta apagado.";
        apagarLabel2.Text = cuatroporcuatro.apagar;
        InfoStackLayout2.IsVisible = true;
    }

    private void botonencender3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout3.IsVisible = true;
        cuatroporcuatro.encender = "El carro esta encendido.";
        encenderLabel3.Text = cuatroporcuatro.encender;
    }

    private void botonbocina3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        InfoStackLayout3.IsVisible = true;
        cuatroporcuatro.bocina = "La bocina esta sonando..";
        bocinaLabel3.Text = cuatroporcuatro.bocina;
    }

    private void botonapagar3(object sender, EventArgs e) // Lógica para manejar el evento de clic en el botón
    {
        cuatroporcuatro.apagar = "El carro esta apagado.";
        apagarLabel3.Text = cuatroporcuatro.apagar;
        InfoStackLayout3.IsVisible = true;
    }


    private void SetBackgroundColor()
    {
        Color backgroundColor = Colors.CadetBlue; // Definir color del fondo de la página

        // Establece el color de fondo de la página
        BackgroundColor = backgroundColor;
    }
}